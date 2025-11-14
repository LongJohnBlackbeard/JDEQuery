using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B109 - .
/// </summary>
public class F31B109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCNCID.
        /// </summary>
        public const string NCNCID = "NCNCID";

        /// <summary>
        /// NCNCNAME.
        /// </summary>
        public const string NCNCNAME = "NCNCNAME";

        /// <summary>
        /// NCNCCOLNM.
        /// </summary>
        public const string NCNCCOLNM = "NCNCCOLNM";

        /// <summary>
        /// NCWCRTR.
        /// </summary>
        public const string NCWCRTR = "NCWCRTR";

        /// <summary>
        /// NCNCRLTYP.
        /// </summary>
        public const string NCNCRLTYP = "NCNCRLTYP";

        /// <summary>
        /// NCNCENT.
        /// </summary>
        public const string NCNCENT = "NCNCENT";

        /// <summary>
        /// NCNCFTOF.
        /// </summary>
        public const string NCNCFTOF = "NCNCFTOF";

        /// <summary>
        /// NCNCFTOF2.
        /// </summary>
        public const string NCNCFTOF2 = "NCNCFTOF2";

        /// <summary>
        /// NCNCFTOF3.
        /// </summary>
        public const string NCNCFTOF3 = "NCNCFTOF3";

        /// <summary>
        /// NCNCRULE.
        /// </summary>
        public const string NCNCRULE = "NCNCRULE";

        /// <summary>
        /// NCNCWHR.
        /// </summary>
        public const string NCNCWHR = "NCNCWHR";

        /// <summary>
        /// NCNCVAL.
        /// </summary>
        public const string NCNCVAL = "NCNCVAL";

        /// <summary>
        /// NCNCVAL2.
        /// </summary>
        public const string NCNCVAL2 = "NCNCVAL2";

        /// <summary>
        /// NCNCVAL3.
        /// </summary>
        public const string NCNCVAL3 = "NCNCVAL3";

        /// <summary>
        /// NCNCTHRES.
        /// </summary>
        public const string NCNCTHRES = "NCNCTHRES";

        /// <summary>
        /// NCNCFTOS.
        /// </summary>
        public const string NCNCFTOS = "NCNCFTOS";

        /// <summary>
        /// NCNCFTOS2.
        /// </summary>
        public const string NCNCFTOS2 = "NCNCFTOS2";

        /// <summary>
        /// NCNCFTOS3.
        /// </summary>
        public const string NCNCFTOS3 = "NCNCFTOS3";

        /// <summary>
        /// NCNCFTOR.
        /// </summary>
        public const string NCNCFTOR = "NCNCFTOR";

        /// <summary>
        /// NCNCFTOR2.
        /// </summary>
        public const string NCNCFTOR2 = "NCNCFTOR2";

        /// <summary>
        /// NCNCFTOR3.
        /// </summary>
        public const string NCNCFTOR3 = "NCNCFTOR3";

        /// <summary>
        /// NCNCCC1.
        /// </summary>
        public const string NCNCCC1 = "NCNCCC1";

        /// <summary>
        /// NCNCCC2.
        /// </summary>
        public const string NCNCCC2 = "NCNCCC2";

        /// <summary>
        /// NCNCCC3.
        /// </summary>
        public const string NCNCCC3 = "NCNCCC3";

        /// <summary>
        /// NCNCCUSF.
        /// </summary>
        public const string NCNCCUSF = "NCNCCUSF";

        /// <summary>
        /// NCURAB.
        /// </summary>
        public const string NCURAB = "NCURAB";

        /// <summary>
        /// NCURAT.
        /// </summary>
        public const string NCURAT = "NCURAT";

        /// <summary>
        /// NCURCD.
        /// </summary>
        public const string NCURCD = "NCURCD";

        /// <summary>
        /// NCURDT.
        /// </summary>
        public const string NCURDT = "NCURDT";

        /// <summary>
        /// NCURRF.
        /// </summary>
        public const string NCURRF = "NCURRF";

        /// <summary>
        /// NCWAB.
        /// </summary>
        public const string NCWAB = "NCWAB";

        /// <summary>
        /// NCWNUM.
        /// </summary>
        public const string NCWNUM = "NCWNUM";

        /// <summary>
        /// NCWCD.
        /// </summary>
        public const string NCWCD = "NCWCD";

        /// <summary>
        /// NCWMDT.
        /// </summary>
        public const string NCWMDT = "NCWMDT";

        /// <summary>
        /// NCWRF.
        /// </summary>
        public const string NCWRF = "NCWRF";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";

        /// <summary>
        /// NCMKEY.
        /// </summary>
        public const string NCMKEY = "NCMKEY";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCNCID", "NCNCID", JdeDataType.Numeric, null, true, true),
        new JdeField("NCNCNAME", "NCNCNAME", JdeDataType.String, 60),
        new JdeField("NCNCCOLNM", "NCNCCOLNM", JdeDataType.String, 40),
        new JdeField("NCWCRTR", "NCWCRTR", JdeDataType.Numeric),
        new JdeField("NCNCRLTYP", "NCNCRLTYP", JdeDataType.String, 2),
        new JdeField("NCNCENT", "NCNCENT", JdeDataType.String, 20),
        new JdeField("NCNCFTOF", "NCNCFTOF", JdeDataType.String, 20),
        new JdeField("NCNCFTOF2", "NCNCFTOF2", JdeDataType.String, 20),
        new JdeField("NCNCFTOF3", "NCNCFTOF3", JdeDataType.String, 20),
        new JdeField("NCNCRULE", "NCNCRULE", JdeDataType.String, 8),
        new JdeField("NCNCWHR", "NCNCWHR", JdeDataType.String, 20),
        new JdeField("NCNCVAL", "NCNCVAL", JdeDataType.String, 60),
        new JdeField("NCNCVAL2", "NCNCVAL2", JdeDataType.String, 60),
        new JdeField("NCNCVAL3", "NCNCVAL3", JdeDataType.String, 60),
        new JdeField("NCNCTHRES", "NCNCTHRES", JdeDataType.Numeric),
        new JdeField("NCNCFTOS", "NCNCFTOS", JdeDataType.String, 20),
        new JdeField("NCNCFTOS2", "NCNCFTOS2", JdeDataType.String, 20),
        new JdeField("NCNCFTOS3", "NCNCFTOS3", JdeDataType.String, 20),
        new JdeField("NCNCFTOR", "NCNCFTOR", JdeDataType.String, 20),
        new JdeField("NCNCFTOR2", "NCNCFTOR2", JdeDataType.String, 20),
        new JdeField("NCNCFTOR3", "NCNCFTOR3", JdeDataType.String, 20),
        new JdeField("NCNCCC1", "NCNCCC1", JdeDataType.String, 20),
        new JdeField("NCNCCC2", "NCNCCC2", JdeDataType.String, 20),
        new JdeField("NCNCCC3", "NCNCCC3", JdeDataType.String, 20),
        new JdeField("NCNCCUSF", "NCNCCUSF", JdeDataType.String, 64),
        new JdeField("NCURAB", "NCURAB", JdeDataType.Numeric),
        new JdeField("NCURAT", "NCURAT", JdeDataType.Numeric),
        new JdeField("NCURCD", "NCURCD", JdeDataType.String, 4),
        new JdeField("NCURDT", "NCURDT", JdeDataType.Numeric),
        new JdeField("NCURRF", "NCURRF", JdeDataType.String, 30),
        new JdeField("NCWAB", "NCWAB", JdeDataType.Numeric),
        new JdeField("NCWNUM", "NCWNUM", JdeDataType.Numeric),
        new JdeField("NCWCD", "NCWCD", JdeDataType.String, 6),
        new JdeField("NCWMDT", "NCWMDT", JdeDataType.Numeric),
        new JdeField("NCWRF", "NCWRF", JdeDataType.String, 60),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20),
        new JdeField("NCMKEY", "NCMKEY", JdeDataType.String, 30),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B109_0", "Primary Key on NCNCID", new[] { "NCNCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B109_2", "Unique Index on NCNCNAME", new[] { "NCNCNAME" }, isUnique: true)
    };
}
