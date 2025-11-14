using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43800 - .
/// </summary>
public class F43800 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRMATC.
        /// </summary>
        public const string PRMATC = "PRMATC";

        /// <summary>
        /// PRDOCO.
        /// </summary>
        public const string PRDOCO = "PRDOCO";

        /// <summary>
        /// PRDCTO.
        /// </summary>
        public const string PRDCTO = "PRDCTO";

        /// <summary>
        /// PRKCOO.
        /// </summary>
        public const string PRKCOO = "PRKCOO";

        /// <summary>
        /// PRMCU.
        /// </summary>
        public const string PRMCU = "PRMCU";

        /// <summary>
        /// PRLNID.
        /// </summary>
        public const string PRLNID = "PRLNID";

        /// <summary>
        /// PRNLIN.
        /// </summary>
        public const string PRNLIN = "PRNLIN";

        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRVINV.
        /// </summary>
        public const string PRVINV = "PRVINV";

        /// <summary>
        /// PRSBL.
        /// </summary>
        public const string PRSBL = "PRSBL";

        /// <summary>
        /// PRSBLT.
        /// </summary>
        public const string PRSBLT = "PRSBLT";

        /// <summary>
        /// PRDGL.
        /// </summary>
        public const string PRDGL = "PRDGL";

        /// <summary>
        /// PRUOM.
        /// </summary>
        public const string PRUOM = "PRUOM";

        /// <summary>
        /// PRUOPN.
        /// </summary>
        public const string PRUOPN = "PRUOPN";

        /// <summary>
        /// PRAOPN.
        /// </summary>
        public const string PRAOPN = "PRAOPN";

        /// <summary>
        /// PRFAP.
        /// </summary>
        public const string PRFAP = "PRFAP";

        /// <summary>
        /// PRCRCD.
        /// </summary>
        public const string PRCRCD = "PRCRCD";

        /// <summary>
        /// PRBCRC.
        /// </summary>
        public const string PRBCRC = "PRBCRC";

        /// <summary>
        /// PRCRR.
        /// </summary>
        public const string PRCRR = "PRCRR";

        /// <summary>
        /// PRDIVJ.
        /// </summary>
        public const string PRDIVJ = "PRDIVJ";

        /// <summary>
        /// PRCRRM.
        /// </summary>
        public const string PRCRRM = "PRCRRM";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRTERM.
        /// </summary>
        public const string PRTERM = "PRTERM";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRTDAY.
        /// </summary>
        public const string PRTDAY = "PRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43800";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRMATC", "PRMATC", JdeDataType.String, 2, true, true),
        new JdeField("PRDOCO", "PRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCTO", "PRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PRKCOO", "PRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PRMCU", "PRMCU", JdeDataType.String, 24, true, true),
        new JdeField("PRLNID", "PRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRNLIN", "PRNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PRVINV", "PRVINV", JdeDataType.String, 50),
        new JdeField("PRSBL", "PRSBL", JdeDataType.String, 16),
        new JdeField("PRSBLT", "PRSBLT", JdeDataType.String, 2),
        new JdeField("PRDGL", "PRDGL", JdeDataType.Numeric),
        new JdeField("PRUOM", "PRUOM", JdeDataType.String, 4),
        new JdeField("PRUOPN", "PRUOPN", JdeDataType.Numeric),
        new JdeField("PRAOPN", "PRAOPN", JdeDataType.Numeric),
        new JdeField("PRFAP", "PRFAP", JdeDataType.Numeric),
        new JdeField("PRCRCD", "PRCRCD", JdeDataType.String, 6),
        new JdeField("PRBCRC", "PRBCRC", JdeDataType.String, 6),
        new JdeField("PRCRR", "PRCRR", JdeDataType.Numeric),
        new JdeField("PRDIVJ", "PRDIVJ", JdeDataType.Numeric),
        new JdeField("PRCRRM", "PRCRRM", JdeDataType.String, 2),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRTERM", "PRTERM", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRTDAY", "PRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43800_0", "Primary Key on PRMATC, PRDOCO, PRDCTO, PRKCOO, PRMCU, PRLNID, PRNLIN, PRDOC", new[] { "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRMCU", "PRLNID", "PRNLIN", "PRDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
