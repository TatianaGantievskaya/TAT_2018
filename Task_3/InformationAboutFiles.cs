using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task_3
{
  /// <summary>
  /// This class was made for receiving information about all the files.
  /// </summary>
  class InformationAboutFiles
  {
    private List<string> dataOnRequest = new List<string>();

    /// <summary>
    /// This method is used for preparation the string to output.
    /// </summary>
    /// <param name="path"> Input parameter. </param>
    /// <returns> It returns formed string. </returns>
    public string PrepareTheOutputString(string path)
    {
      StringBuilder preparedString = new StringBuilder();
      preparedString.Append("Full path to the file: ").Append(path);
      return preparedString.ToString();
    }

    /// <summary>
    /// This method gets the list of contained catalogs and full paths to them.
    /// </summary>
    /// <param name="path"> Input parameter, the path which is defined by the user at first, but after it is the path to subcatalog. </param>
    /// <returns> It returns the full paths to subcatalogs. </returns>
    public List<string> GetTheListOfFullPathsOfSubcatalogs(string path)
    {
      DirectoryInfo catalog = new DirectoryInfo(path);
      List<string> listOfPaths = new List<string>();
      DirectoryInfo[] subcatalogs = catalog.GetDirectories();
      foreach (var subcatalog in subcatalogs)
      {
        listOfPaths.Add(subcatalog.FullName);
      }
      return listOfPaths;
    }

    /// <summary>
    /// This method gets the list of contained files and full paths to them.
    /// </summary>
    /// <param name="path"> Input parameter, the path which is defined by the user at first, but after it is the path to subcatalog. </param>
    /// <returns> It returns the full paths to files. </returns>
    public List<string> GetTheListOfFullPathsOfFiles(string path)
    {
      DirectoryInfo catalog = new DirectoryInfo(path);
      List<string> listOfFiles = new List<string>();
      FileInfo[] files = catalog.GetFiles();
      foreach (var file in files)
      {
        listOfFiles.Add(file.FullName);
      }
      return listOfFiles;
    }

    /// <summary>
    /// This method gets all the information about the contained files.
    /// </summary>
    /// <param name="path"> Input parameter, at first it is entered by the user, but then it is the path to subcatalog. </param>
    /// <returns> It returns all the information about the files in catalog and subcatalogs (full path, size, creation date). </returns>
    public List<string> GetAllTheInfoAboutFiles(string path, string extension)
    {
      List<string> filesPaths = GetTheListOfFullPathsOfFiles(path);
      foreach (var filePath in filesPaths)
      {
        dataOnRequest.Add(filePath);
      }
      List<string> catalogsPaths = GetTheListOfFullPathsOfSubcatalogs(path);
      foreach (var catalogPath in catalogsPaths)
      {
        GetAllTheInfoAboutFiles(catalogPath, extension);
      }
      return dataOnRequest;
    }

    public List<string> GetTheListOfFilesWithSpecifiedExtension(string path, string extension)
    {
      DirectoryInfo catalog = new DirectoryInfo(path);
      List<string> listOfFiles = new List<string>();
      FileInfo[] files = catalog.GetFiles();
      foreach (var file in files)
      {
        if (file.Extension.Equals(extension))
        {
          listOfFiles.Add(file.FullName);
        }
      }
      return listOfFiles;
    }
  }
}