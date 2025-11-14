using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38014 - .
/// </summary>
public class F38014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRDMCT.
        /// </summary>
        public const string DRDMCT = "DRDMCT";

        /// <summary>
        /// DRDMCS.
        /// </summary>
        public const string DRDMCS = "DRDMCS";

        /// <summary>
        /// DRDTO.
        /// </summary>
        public const string DRDTO = "DRDTO";

        /// <summary>
        /// DRITM.
        /// </summary>
        public const string DRITM = "DRITM";

        /// <summary>
        /// DRUOM.
        /// </summary>
        public const string DRUOM = "DRUOM";

        /// <summary>
        /// DRBALP.
        /// </summary>
        public const string DRBALP = "DRBALP";

        /// <summary>
        /// DRPMLT.
        /// </summary>
        public const string DRPMLT = "DRPMLT";

        /// <summary>
        /// DRBMLT.
        /// </summary>
        public const string DRBMLT = "DRBMLT";

        /// <summary>
        /// DRUV.
        /// </summary>
        public const string DRUV = "DRUV";

        /// <summary>
        /// DRASN.
        /// </summary>
        public const string DRASN = "DRASN";

        /// <summary>
        /// DRCRCD.
        /// </summary>
        public const string DRCRCD = "DRCRCD";

        /// <summary>
        /// DRURCD.
        /// </summary>
        public const string DRURCD = "DRURCD";

        /// <summary>
        /// DRURDT.
        /// </summary>
        public const string DRURDT = "DRURDT";

        /// <summary>
        /// DRURAT.
        /// </summary>
        public const string DRURAT = "DRURAT";

        /// <summary>
        /// DRURAB.
        /// </summary>
        public const string DRURAB = "DRURAB";

        /// <summary>
        /// DRURRF.
        /// </summary>
        public const string DRURRF = "DRURRF";

        /// <summary>
        /// DRUSER.
        /// </summary>
        public const string DRUSER = "DRUSER";

        /// <summary>
        /// DRPID.
        /// </summary>
        public const string DRPID = "DRPID";

        /// <summary>
        /// DRJOBN.
        /// </summary>
        public const string DRJOBN = "DRJOBN";

        /// <summary>
        /// DRUPMJ.
        /// </summary>
        public const string DRUPMJ = "DRUPMJ";

        /// <summary>
        /// DRTDAY.
        /// </summary>
        public const string DRTDAY = "DRTDAY";

        /// <summary>
        /// DREXDJ.
        /// </summary>
        public const string DREXDJ = "DREXDJ";

        /// <summary>
        /// DREFTJ.
        /// </summary>
        public const string DREFTJ = "DREFTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F38014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRDMCT", "DRDMCT", JdeDataType.String, 24, true, true),
        new JdeField("DRDMCS", "DRDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("DRDTO", "DRDTO", JdeDataType.String, 2, true, true),
        new JdeField("DRITM", "DRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("DRUOM", "DRUOM", JdeDataType.String, 4),
        new JdeField("DRBALP", "DRBALP", JdeDataType.String, 2),
        new JdeField("DRPMLT", "DRPMLT", JdeDataType.Numeric),
        new JdeField("DRBMLT", "DRBMLT", JdeDataType.Numeric),
        new JdeField("DRUV", "DRUV", JdeDataType.Numeric),
        new JdeField("DRASN", "DRASN", JdeDataType.String, 16),
        new JdeField("DRCRCD", "DRCRCD", JdeDataType.String, 6),
        new JdeField("DRURCD", "DRURCD", JdeDataType.String, 4),
        new JdeField("DRURDT", "DRURDT", JdeDataType.Numeric),
        new JdeField("DRURAT", "DRURAT", JdeDataType.Numeric),
        new JdeField("DRURAB", "DRURAB", JdeDataType.Numeric),
        new JdeField("DRURRF", "DRURRF", JdeDataType.String, 30),
        new JdeField("DRUSER", "DRUSER", JdeDataType.String, 20),
        new JdeField("DRPID", "DRPID", JdeDataType.String, 20),
        new JdeField("DRJOBN", "DRJOBN", JdeDataType.String, 20),
        new JdeField("DRUPMJ", "DRUPMJ", JdeDataType.Numeric),
        new JdeField("DRTDAY", "DRTDAY", JdeDataType.Numeric),
        new JdeField("DREXDJ", "DREXDJ", JdeDataType.Numeric),
        new JdeField("DREFTJ", "DREFTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38014_0", "Primary Key on DRDMCT, DRDMCS, DRDTO, DRITM", new[] { "DRDMCT", "DRDMCS", "DRDTO", "DRITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F38014_2", "Index on DRDMCT, DRDMCS, DRITM", new[] { "DRDMCT", "DRDMCS", "DRITM" })
    };
}
