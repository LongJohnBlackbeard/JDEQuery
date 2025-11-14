using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0705 - .
/// </summary>
public class F31B0705 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BNNCID.
        /// </summary>
        public const string BNNCID = "BNNCID";

        /// <summary>
        /// BNEURID.
        /// </summary>
        public const string BNEURID = "BNEURID";

        /// <summary>
        /// BNNCNAME.
        /// </summary>
        public const string BNNCNAME = "BNNCNAME";

        /// <summary>
        /// BNNCCOLNM.
        /// </summary>
        public const string BNNCCOLNM = "BNNCCOLNM";

        /// <summary>
        /// BNWCRTR.
        /// </summary>
        public const string BNWCRTR = "BNWCRTR";

        /// <summary>
        /// BNNCRLTYP.
        /// </summary>
        public const string BNNCRLTYP = "BNNCRLTYP";

        /// <summary>
        /// BNNCENT.
        /// </summary>
        public const string BNNCENT = "BNNCENT";

        /// <summary>
        /// BNNCFTOF.
        /// </summary>
        public const string BNNCFTOF = "BNNCFTOF";

        /// <summary>
        /// BNNCFTOF2.
        /// </summary>
        public const string BNNCFTOF2 = "BNNCFTOF2";

        /// <summary>
        /// BNNCFTOF3.
        /// </summary>
        public const string BNNCFTOF3 = "BNNCFTOF3";

        /// <summary>
        /// BNNCRULE.
        /// </summary>
        public const string BNNCRULE = "BNNCRULE";

        /// <summary>
        /// BNNCWHR.
        /// </summary>
        public const string BNNCWHR = "BNNCWHR";

        /// <summary>
        /// BNNCVAL.
        /// </summary>
        public const string BNNCVAL = "BNNCVAL";

        /// <summary>
        /// BNNCVAL2.
        /// </summary>
        public const string BNNCVAL2 = "BNNCVAL2";

        /// <summary>
        /// BNNCVAL3.
        /// </summary>
        public const string BNNCVAL3 = "BNNCVAL3";

        /// <summary>
        /// BNNCTHRES.
        /// </summary>
        public const string BNNCTHRES = "BNNCTHRES";

        /// <summary>
        /// BNNCFTOS.
        /// </summary>
        public const string BNNCFTOS = "BNNCFTOS";

        /// <summary>
        /// BNNCFTOS2.
        /// </summary>
        public const string BNNCFTOS2 = "BNNCFTOS2";

        /// <summary>
        /// BNNCFTOS3.
        /// </summary>
        public const string BNNCFTOS3 = "BNNCFTOS3";

        /// <summary>
        /// BNNCFTOR.
        /// </summary>
        public const string BNNCFTOR = "BNNCFTOR";

        /// <summary>
        /// BNNCFTOR2.
        /// </summary>
        public const string BNNCFTOR2 = "BNNCFTOR2";

        /// <summary>
        /// BNNCFTOR3.
        /// </summary>
        public const string BNNCFTOR3 = "BNNCFTOR3";

        /// <summary>
        /// BNNCCC1.
        /// </summary>
        public const string BNNCCC1 = "BNNCCC1";

        /// <summary>
        /// BNNCCC2.
        /// </summary>
        public const string BNNCCC2 = "BNNCCC2";

        /// <summary>
        /// BNNCCC3.
        /// </summary>
        public const string BNNCCC3 = "BNNCCC3";

        /// <summary>
        /// BNNCCUSF.
        /// </summary>
        public const string BNNCCUSF = "BNNCCUSF";

        /// <summary>
        /// BNURAB.
        /// </summary>
        public const string BNURAB = "BNURAB";

        /// <summary>
        /// BNURAT.
        /// </summary>
        public const string BNURAT = "BNURAT";

        /// <summary>
        /// BNURCD.
        /// </summary>
        public const string BNURCD = "BNURCD";

        /// <summary>
        /// BNURDT.
        /// </summary>
        public const string BNURDT = "BNURDT";

        /// <summary>
        /// BNURRF.
        /// </summary>
        public const string BNURRF = "BNURRF";

        /// <summary>
        /// BNJOBN.
        /// </summary>
        public const string BNJOBN = "BNJOBN";

        /// <summary>
        /// BNPID.
        /// </summary>
        public const string BNPID = "BNPID";

        /// <summary>
        /// BNTDAY.
        /// </summary>
        public const string BNTDAY = "BNTDAY";

        /// <summary>
        /// BNUPMJ.
        /// </summary>
        public const string BNUPMJ = "BNUPMJ";

        /// <summary>
        /// BNUSER.
        /// </summary>
        public const string BNUSER = "BNUSER";

        /// <summary>
        /// BNWAB.
        /// </summary>
        public const string BNWAB = "BNWAB";

        /// <summary>
        /// BNWCD.
        /// </summary>
        public const string BNWCD = "BNWCD";

        /// <summary>
        /// BNWMDT.
        /// </summary>
        public const string BNWMDT = "BNWMDT";

        /// <summary>
        /// BNWNUM.
        /// </summary>
        public const string BNWNUM = "BNWNUM";

        /// <summary>
        /// BNWRF.
        /// </summary>
        public const string BNWRF = "BNWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0705";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BNNCID", "BNNCID", JdeDataType.Numeric, null, true, true),
        new JdeField("BNEURID", "BNEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("BNNCNAME", "BNNCNAME", JdeDataType.String, 60),
        new JdeField("BNNCCOLNM", "BNNCCOLNM", JdeDataType.String, 40),
        new JdeField("BNWCRTR", "BNWCRTR", JdeDataType.Numeric),
        new JdeField("BNNCRLTYP", "BNNCRLTYP", JdeDataType.String, 2),
        new JdeField("BNNCENT", "BNNCENT", JdeDataType.String, 20),
        new JdeField("BNNCFTOF", "BNNCFTOF", JdeDataType.String, 20),
        new JdeField("BNNCFTOF2", "BNNCFTOF2", JdeDataType.String, 20),
        new JdeField("BNNCFTOF3", "BNNCFTOF3", JdeDataType.String, 20),
        new JdeField("BNNCRULE", "BNNCRULE", JdeDataType.String, 8),
        new JdeField("BNNCWHR", "BNNCWHR", JdeDataType.String, 20),
        new JdeField("BNNCVAL", "BNNCVAL", JdeDataType.String, 60),
        new JdeField("BNNCVAL2", "BNNCVAL2", JdeDataType.String, 60),
        new JdeField("BNNCVAL3", "BNNCVAL3", JdeDataType.String, 60),
        new JdeField("BNNCTHRES", "BNNCTHRES", JdeDataType.Numeric),
        new JdeField("BNNCFTOS", "BNNCFTOS", JdeDataType.String, 20),
        new JdeField("BNNCFTOS2", "BNNCFTOS2", JdeDataType.String, 20),
        new JdeField("BNNCFTOS3", "BNNCFTOS3", JdeDataType.String, 20),
        new JdeField("BNNCFTOR", "BNNCFTOR", JdeDataType.String, 20),
        new JdeField("BNNCFTOR2", "BNNCFTOR2", JdeDataType.String, 20),
        new JdeField("BNNCFTOR3", "BNNCFTOR3", JdeDataType.String, 20),
        new JdeField("BNNCCC1", "BNNCCC1", JdeDataType.String, 20),
        new JdeField("BNNCCC2", "BNNCCC2", JdeDataType.String, 20),
        new JdeField("BNNCCC3", "BNNCCC3", JdeDataType.String, 20),
        new JdeField("BNNCCUSF", "BNNCCUSF", JdeDataType.String, 64),
        new JdeField("BNURAB", "BNURAB", JdeDataType.Numeric),
        new JdeField("BNURAT", "BNURAT", JdeDataType.Numeric),
        new JdeField("BNURCD", "BNURCD", JdeDataType.String, 4),
        new JdeField("BNURDT", "BNURDT", JdeDataType.Numeric),
        new JdeField("BNURRF", "BNURRF", JdeDataType.String, 30),
        new JdeField("BNJOBN", "BNJOBN", JdeDataType.String, 20),
        new JdeField("BNPID", "BNPID", JdeDataType.String, 20),
        new JdeField("BNTDAY", "BNTDAY", JdeDataType.Numeric),
        new JdeField("BNUPMJ", "BNUPMJ", JdeDataType.Numeric),
        new JdeField("BNUSER", "BNUSER", JdeDataType.String, 20),
        new JdeField("BNWAB", "BNWAB", JdeDataType.Numeric),
        new JdeField("BNWCD", "BNWCD", JdeDataType.String, 6),
        new JdeField("BNWMDT", "BNWMDT", JdeDataType.Numeric),
        new JdeField("BNWNUM", "BNWNUM", JdeDataType.Numeric),
        new JdeField("BNWRF", "BNWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0705_0", "Primary Key on BNNCID, BNEURID", new[] { "BNNCID", "BNEURID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0705_2", "Index on BNEURID, BNNCID", new[] { "BNEURID", "BNNCID" })
    };
}
