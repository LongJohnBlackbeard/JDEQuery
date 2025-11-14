using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX05 - .
/// </summary>
public class FY5AHX05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DITASKID.
        /// </summary>
        public const string DITASKID = "DITASKID";

        /// <summary>
        /// DITASKNM.
        /// </summary>
        public const string DITASKNM = "DITASKNM";

        /// <summary>
        /// DILNGTASK.
        /// </summary>
        public const string DILNGTASK = "DILNGTASK";

        /// <summary>
        /// DITASKTYPE.
        /// </summary>
        public const string DITASKTYPE = "DITASKTYPE";

        /// <summary>
        /// DIRULEID.
        /// </summary>
        public const string DIRULEID = "DIRULEID";

        /// <summary>
        /// DIOBNM.
        /// </summary>
        public const string DIOBNM = "DIOBNM";

        /// <summary>
        /// DIVER.
        /// </summary>
        public const string DIVER = "DIVER";

        /// <summary>
        /// DIFMNM.
        /// </summary>
        public const string DIFMNM = "DIFMNM";

        /// <summary>
        /// DISYAO.
        /// </summary>
        public const string DISYAO = "DISYAO";

        /// <summary>
        /// DIOPCD.
        /// </summary>
        public const string DIOPCD = "DIOPCD";

        /// <summary>
        /// DICMMDPATH.
        /// </summary>
        public const string DICMMDPATH = "DICMMDPATH";

        /// <summary>
        /// DIEXEPARMS.
        /// </summary>
        public const string DIEXEPARMS = "DIEXEPARMS";

        /// <summary>
        /// DIWRKDIR.
        /// </summary>
        public const string DIWRKDIR = "DIWRKDIR";

        /// <summary>
        /// DIQUESTYP.
        /// </summary>
        public const string DIQUESTYP = "DIQUESTYP";

        /// <summary>
        /// DIRCCODE.
        /// </summary>
        public const string DIRCCODE = "DIRCCODE";

        /// <summary>
        /// DIRCCODETP.
        /// </summary>
        public const string DIRCCODETP = "DIRCCODETP";

        /// <summary>
        /// DIICNI.
        /// </summary>
        public const string DIICNI = "DIICNI";

        /// <summary>
        /// DIPTH.
        /// </summary>
        public const string DIPTH = "DIPTH";

        /// <summary>
        /// DISY.
        /// </summary>
        public const string DISY = "DISY";

        /// <summary>
        /// DISYR.
        /// </summary>
        public const string DISYR = "DISYR";

        /// <summary>
        /// DIBASEHRS.
        /// </summary>
        public const string DIBASEHRS = "DIBASEHRS";

        /// <summary>
        /// DIBASERSC.
        /// </summary>
        public const string DIBASERSC = "DIBASERSC";

        /// <summary>
        /// DIUNITOFMS.
        /// </summary>
        public const string DIUNITOFMS = "DIUNITOFMS";

        /// <summary>
        /// DITASCKACT.
        /// </summary>
        public const string DITASCKACT = "DITASCKACT";

        /// <summary>
        /// DIREQOPTFG.
        /// </summary>
        public const string DIREQOPTFG = "DIREQOPTFG";

        /// <summary>
        /// DIACTIVAFG.
        /// </summary>
        public const string DIACTIVAFG = "DIACTIVAFG";

        /// <summary>
        /// DIBPMR.
        /// </summary>
        public const string DIBPMR = "DIBPMR";

        /// <summary>
        /// DILKRT.
        /// </summary>
        public const string DILKRT = "DILKRT";

        /// <summary>
        /// DILKPT.
        /// </summary>
        public const string DILKPT = "DILKPT";

        /// <summary>
        /// DILKCT.
        /// </summary>
        public const string DILKCT = "DILKCT";

        /// <summary>
        /// DILKFR.
        /// </summary>
        public const string DILKFR = "DILKFR";

        /// <summary>
        /// DILKTR.
        /// </summary>
        public const string DILKTR = "DILKTR";

        /// <summary>
        /// DIPOOPTID.
        /// </summary>
        public const string DIPOOPTID = "DIPOOPTID";

        /// <summary>
        /// DIPOTASKID.
        /// </summary>
        public const string DIPOTASKID = "DIPOTASKID";

        /// <summary>
        /// DITASKCAT1.
        /// </summary>
        public const string DITASKCAT1 = "DITASKCAT1";

        /// <summary>
        /// DITASKCAT2.
        /// </summary>
        public const string DITASKCAT2 = "DITASKCAT2";

        /// <summary>
        /// DITASKCAT3.
        /// </summary>
        public const string DITASKCAT3 = "DITASKCAT3";

        /// <summary>
        /// DITASKCAT4.
        /// </summary>
        public const string DITASKCAT4 = "DITASKCAT4";

        /// <summary>
        /// DITASKCAT5.
        /// </summary>
        public const string DITASKCAT5 = "DITASKCAT5";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIFUFTASK1.
        /// </summary>
        public const string DIFUFTASK1 = "DIFUFTASK1";

        /// <summary>
        /// DIFUFTASK2.
        /// </summary>
        public const string DIFUFTASK2 = "DIFUFTASK2";

        /// <summary>
        /// DIFUFTASK3.
        /// </summary>
        public const string DIFUFTASK3 = "DIFUFTASK3";

        /// <summary>
        /// DIFUFTASK4.
        /// </summary>
        public const string DIFUFTASK4 = "DIFUFTASK4";

        /// <summary>
        /// DIFUFTASK5.
        /// </summary>
        public const string DIFUFTASK5 = "DIFUFTASK5";

        /// <summary>
        /// DIFUFTASK6.
        /// </summary>
        public const string DIFUFTASK6 = "DIFUFTASK6";

        /// <summary>
        /// DIFUFTASK7.
        /// </summary>
        public const string DIFUFTASK7 = "DIFUFTASK7";

        /// <summary>
        /// DIFUFTASK8.
        /// </summary>
        public const string DIFUFTASK8 = "DIFUFTASK8";

        /// <summary>
        /// DIY5AHOTID.
        /// </summary>
        public const string DIY5AHOTID = "DIY5AHOTID";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AHX05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DITASKID", "DITASKID", JdeDataType.String, 72, true, true),
        new JdeField("DITASKNM", "DITASKNM", JdeDataType.String, 80),
        new JdeField("DILNGTASK", "DILNGTASK", JdeDataType.String, 160),
        new JdeField("DITASKTYPE", "DITASKTYPE", JdeDataType.String, 4),
        new JdeField("DIRULEID", "DIRULEID", JdeDataType.String, 30),
        new JdeField("DIOBNM", "DIOBNM", JdeDataType.String, 20),
        new JdeField("DIVER", "DIVER", JdeDataType.String, 20),
        new JdeField("DIFMNM", "DIFMNM", JdeDataType.String, 20),
        new JdeField("DISYAO", "DISYAO", JdeDataType.String, 8),
        new JdeField("DIOPCD", "DIOPCD", JdeDataType.String, 2),
        new JdeField("DICMMDPATH", "DICMMDPATH", JdeDataType.String, 512),
        new JdeField("DIEXEPARMS", "DIEXEPARMS", JdeDataType.String, 512),
        new JdeField("DIWRKDIR", "DIWRKDIR", JdeDataType.String, 512),
        new JdeField("DIQUESTYP", "DIQUESTYP", JdeDataType.String, 10),
        new JdeField("DIRCCODE", "DIRCCODE", JdeDataType.String, 8),
        new JdeField("DIRCCODETP", "DIRCCODETP", JdeDataType.String, 4),
        new JdeField("DIICNI", "DIICNI", JdeDataType.Numeric),
        new JdeField("DIPTH", "DIPTH", JdeDataType.String, 240),
        new JdeField("DISY", "DISY", JdeDataType.String, 8),
        new JdeField("DISYR", "DISYR", JdeDataType.String, 8),
        new JdeField("DIBASEHRS", "DIBASEHRS", JdeDataType.Numeric),
        new JdeField("DIBASERSC", "DIBASERSC", JdeDataType.String, 16),
        new JdeField("DIUNITOFMS", "DIUNITOFMS", JdeDataType.String, 4),
        new JdeField("DITASCKACT", "DITASCKACT", JdeDataType.String, 2),
        new JdeField("DIREQOPTFG", "DIREQOPTFG", JdeDataType.String, 2),
        new JdeField("DIACTIVAFG", "DIACTIVAFG", JdeDataType.String, 2),
        new JdeField("DIBPMR", "DIBPMR", JdeDataType.String, 80),
        new JdeField("DILKRT", "DILKRT", JdeDataType.String, 10),
        new JdeField("DILKPT", "DILKPT", JdeDataType.String, 72),
        new JdeField("DILKCT", "DILKCT", JdeDataType.String, 72),
        new JdeField("DILKFR", "DILKFR", JdeDataType.String, 20),
        new JdeField("DILKTR", "DILKTR", JdeDataType.String, 20),
        new JdeField("DIPOOPTID", "DIPOOPTID", JdeDataType.String, 72),
        new JdeField("DIPOTASKID", "DIPOTASKID", JdeDataType.String, 72),
        new JdeField("DITASKCAT1", "DITASKCAT1", JdeDataType.String, 12),
        new JdeField("DITASKCAT2", "DITASKCAT2", JdeDataType.String, 12),
        new JdeField("DITASKCAT3", "DITASKCAT3", JdeDataType.String, 12),
        new JdeField("DITASKCAT4", "DITASKCAT4", JdeDataType.String, 12),
        new JdeField("DITASKCAT5", "DITASKCAT5", JdeDataType.String, 12),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIFUFTASK1", "DIFUFTASK1", JdeDataType.String, 2),
        new JdeField("DIFUFTASK2", "DIFUFTASK2", JdeDataType.String, 6),
        new JdeField("DIFUFTASK3", "DIFUFTASK3", JdeDataType.String, 6),
        new JdeField("DIFUFTASK4", "DIFUFTASK4", JdeDataType.String, 20),
        new JdeField("DIFUFTASK5", "DIFUFTASK5", JdeDataType.String, 20),
        new JdeField("DIFUFTASK6", "DIFUFTASK6", JdeDataType.String, 40),
        new JdeField("DIFUFTASK7", "DIFUFTASK7", JdeDataType.String, 80),
        new JdeField("DIFUFTASK8", "DIFUFTASK8", JdeDataType.String, 160),
        new JdeField("DIY5AHOTID", "DIY5AHOTID", JdeDataType.String, 72)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX05_0", "Primary Key on DITASKID", new[] { "DITASKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AHX05_10", "Index on DIY5AHOTID", new[] { "DIY5AHOTID" }),
        new JdeIndex("FY5AHX05_2", "Index on DITASKNM", new[] { "DITASKNM" }),
        new JdeIndex("FY5AHX05_3", "Index on DIOBNM, DIVER, DIFMNM", new[] { "DIOBNM", "DIVER", "DIFMNM" }),
        new JdeIndex("FY5AHX05_4", "Index on DITASKTYPE", new[] { "DITASKTYPE" }),
        new JdeIndex("FY5AHX05_5", "Index on DIRULEID", new[] { "DIRULEID" }),
        new JdeIndex("FY5AHX05_6", "Index on DIFUFTASK4", new[] { "DIFUFTASK4" }),
        new JdeIndex("FY5AHX05_7", "Index on DIFUFTASK4, DIFUFTASK6", new[] { "DIFUFTASK4", "DIFUFTASK6" }),
        new JdeIndex("FY5AHX05_8", "Index on DIFUFTASK7", new[] { "DIFUFTASK7" }),
        new JdeIndex("FY5AHX05_9", "Index on DISY, DITASCKACT, DITASKID", new[] { "DISY", "DITASCKACT", "DITASKID" })
    };
}
