using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G041 - .
/// </summary>
public class F40G041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISITM.
        /// </summary>
        public const string ISITM = "ISITM";

        /// <summary>
        /// ISMCU.
        /// </summary>
        public const string ISMCU = "ISMCU";

        /// <summary>
        /// ISLITM.
        /// </summary>
        public const string ISLITM = "ISLITM";

        /// <summary>
        /// ISTARGORG.
        /// </summary>
        public const string ISTARGORG = "ISTARGORG";

        /// <summary>
        /// ISHARACT.
        /// </summary>
        public const string ISHARACT = "ISHARACT";

        /// <summary>
        /// ISHAWUOMT.
        /// </summary>
        public const string ISHAWUOMT = "ISHAWUOMT";

        /// <summary>
        /// ISPRACT.
        /// </summary>
        public const string ISPRACT = "ISPRACT";

        /// <summary>
        /// ISPAWUOMT.
        /// </summary>
        public const string ISPAWUOMT = "ISPAWUOMT";

        /// <summary>
        /// ISREBLK.
        /// </summary>
        public const string ISREBLK = "ISREBLK";

        /// <summary>
        /// ISREWUOMT.
        /// </summary>
        public const string ISREWUOMT = "ISREWUOMT";

        /// <summary>
        /// ISSUBACT.
        /// </summary>
        public const string ISSUBACT = "ISSUBACT";

        /// <summary>
        /// ISSAWUOMT.
        /// </summary>
        public const string ISSAWUOMT = "ISSAWUOMT";

        /// <summary>
        /// ISMGFID.
        /// </summary>
        public const string ISMGFID = "ISMGFID";

        /// <summary>
        /// ISMGFNAME.
        /// </summary>
        public const string ISMGFNAME = "ISMGFNAME";

        /// <summary>
        /// ISPADDQTY.
        /// </summary>
        public const string ISPADDQTY = "ISPADDQTY";

        /// <summary>
        /// ISNADDQTY.
        /// </summary>
        public const string ISNADDQTY = "ISNADDQTY";

        /// <summary>
        /// ISXADDQTY.
        /// </summary>
        public const string ISXADDQTY = "ISXADDQTY";

        /// <summary>
        /// ISPARQTY.
        /// </summary>
        public const string ISPARQTY = "ISPARQTY";

        /// <summary>
        /// ISPADTUOM.
        /// </summary>
        public const string ISPADTUOM = "ISPADTUOM";

        /// <summary>
        /// ISPADRUM.
        /// </summary>
        public const string ISPADRUM = "ISPADRUM";

        /// <summary>
        /// ISPCDREG.
        /// </summary>
        public const string ISPCDREG = "ISPCDREG";

        /// <summary>
        /// ISPCDREG2.
        /// </summary>
        public const string ISPCDREG2 = "ISPCDREG2";

        /// <summary>
        /// ISCHMRST.
        /// </summary>
        public const string ISCHMRST = "ISCHMRST";

        /// <summary>
        /// ISSPTYPE.
        /// </summary>
        public const string ISSPTYPE = "ISSPTYPE";

        /// <summary>
        /// ISCHEMCDE.
        /// </summary>
        public const string ISCHEMCDE = "ISCHEMCDE";

        /// <summary>
        /// ISURCD.
        /// </summary>
        public const string ISURCD = "ISURCD";

        /// <summary>
        /// ISURDT.
        /// </summary>
        public const string ISURDT = "ISURDT";

        /// <summary>
        /// ISURRF.
        /// </summary>
        public const string ISURRF = "ISURRF";

        /// <summary>
        /// ISURAT.
        /// </summary>
        public const string ISURAT = "ISURAT";

        /// <summary>
        /// ISURAB.
        /// </summary>
        public const string ISURAB = "ISURAB";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISTORG.
        /// </summary>
        public const string ISTORG = "ISTORG";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISUUPMJ.
        /// </summary>
        public const string ISUUPMJ = "ISUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISITM", "ISITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ISMCU", "ISMCU", JdeDataType.String, 24, true, true),
        new JdeField("ISLITM", "ISLITM", JdeDataType.String, 50),
        new JdeField("ISTARGORG", "ISTARGORG", JdeDataType.String, 100),
        new JdeField("ISHARACT", "ISHARACT", JdeDataType.Numeric),
        new JdeField("ISHAWUOMT", "ISHAWUOMT", JdeDataType.String, 2),
        new JdeField("ISPRACT", "ISPRACT", JdeDataType.Numeric),
        new JdeField("ISPAWUOMT", "ISPAWUOMT", JdeDataType.String, 2),
        new JdeField("ISREBLK", "ISREBLK", JdeDataType.Numeric),
        new JdeField("ISREWUOMT", "ISREWUOMT", JdeDataType.String, 2),
        new JdeField("ISSUBACT", "ISSUBACT", JdeDataType.Numeric),
        new JdeField("ISSAWUOMT", "ISSAWUOMT", JdeDataType.String, 2),
        new JdeField("ISMGFID", "ISMGFID", JdeDataType.String, 60),
        new JdeField("ISMGFNAME", "ISMGFNAME", JdeDataType.String, 60),
        new JdeField("ISPADDQTY", "ISPADDQTY", JdeDataType.Numeric),
        new JdeField("ISNADDQTY", "ISNADDQTY", JdeDataType.Numeric),
        new JdeField("ISXADDQTY", "ISXADDQTY", JdeDataType.Numeric),
        new JdeField("ISPARQTY", "ISPARQTY", JdeDataType.Numeric),
        new JdeField("ISPADTUOM", "ISPADTUOM", JdeDataType.String, 4),
        new JdeField("ISPADRUM", "ISPADRUM", JdeDataType.String, 4),
        new JdeField("ISPCDREG", "ISPCDREG", JdeDataType.String, 60),
        new JdeField("ISPCDREG2", "ISPCDREG2", JdeDataType.String, 60),
        new JdeField("ISCHMRST", "ISCHMRST", JdeDataType.String, 2),
        new JdeField("ISSPTYPE", "ISSPTYPE", JdeDataType.String, 4),
        new JdeField("ISCHEMCDE", "ISCHEMCDE", JdeDataType.String, 16),
        new JdeField("ISURCD", "ISURCD", JdeDataType.String, 4),
        new JdeField("ISURDT", "ISURDT", JdeDataType.Numeric),
        new JdeField("ISURRF", "ISURRF", JdeDataType.String, 30),
        new JdeField("ISURAT", "ISURAT", JdeDataType.Numeric),
        new JdeField("ISURAB", "ISURAB", JdeDataType.Numeric),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISTORG", "ISTORG", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISUUPMJ", "ISUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G041_0", "Primary Key on ISITM, ISMCU", new[] { "ISITM", "ISMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
