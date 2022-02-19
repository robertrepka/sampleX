using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;


namespace sampleX
{
    class RRzip
    {

        public void ExtractZipFile(string FilenameIn, string FilenameOut)
        {
            ZipFile zf = null;
            try
            {
                FileStream fs = File.OpenRead(FilenameIn);
                zf = new ZipFile(fs);
                
                foreach (ZipEntry zipEntry in zf)
                {
                    String entryFileName = zipEntry.Name;
                    byte[] buffer = new byte[4096];		// 4K is optimum
                    Stream zipStream = zf.GetInputStream(zipEntry);

                    //String fullZipToPath = Path.Combine(outFolder, entryFileName);
                    String fullZipToPath = FilenameOut;

                    string directoryName = Path.GetDirectoryName(fullZipToPath);
                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(directoryName);
                    }

                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                }
            }
            finally
            {
                if (zf != null)
                {
                    zf.IsStreamOwner = true; // Makes close also shut the underlying stream
                    zf.Close(); // Ensure we release resources
                }
            }
        }
        
        public void CompressFile(string inputPath, string outputPath)
        {
            FileInfo outFileInfo = new FileInfo(outputPath);
            FileInfo inFileInfo = new FileInfo(inputPath);

            // Create the output directory if it does not exist
            if (!Directory.Exists(outFileInfo.Directory.FullName))
            {
                Directory.CreateDirectory(outFileInfo.Directory.FullName);
            }

            // Compress
            using (FileStream fsOut = File.Create(outputPath))
            {
                using (ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(fsOut))
                {
                    zipStream.SetLevel(3);

                    ICSharpCode.SharpZipLib.Zip.ZipEntry newEntry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(inFileInfo.Name);
                    newEntry.DateTime = DateTime.UtcNow;
                    zipStream.PutNextEntry(newEntry);

                    byte[] buffer = new byte[4096];
                    using (FileStream streamReader = File.OpenRead(inputPath))
                    {
                        ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(streamReader, zipStream, buffer);
                    }

                    zipStream.CloseEntry();
                    zipStream.IsStreamOwner = true;
                    zipStream.Close();
                }
            }
        }
    
    }
}
