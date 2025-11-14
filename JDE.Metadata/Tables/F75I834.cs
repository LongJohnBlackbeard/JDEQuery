using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I834 - .
/// </summary>
public class F75I834 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BEKCO.
        /// </summary>
        public const string BEKCO = "BEKCO";

        /// <summary>
        /// BEDCT.
        /// </summary>
        public const string BEDCT = "BEDCT";

        /// <summary>
        /// BEDOC.
        /// </summary>
        public const string BEDOC = "BEDOC";

        /// <summary>
        /// BEI75INVNO.
        /// </summary>
        public const string BEI75INVNO = "BEI75INVNO";

        /// <summary>
        /// BEI75BOEXP.
        /// </summary>
        public const string BEI75BOEXP = "BEI75BOEXP";

        /// <summary>
        /// BEI75BOEXD.
        /// </summary>
        public const string BEI75BOEXD = "BEI75BOEXD";

        /// <summary>
        /// BEUSER.
        /// </summary>
        public const string BEUSER = "BEUSER";

        /// <summary>
        /// BEPID.
        /// </summary>
        public const string BEPID = "BEPID";

        /// <summary>
        /// BEJOBN.
        /// </summary>
        public const string BEJOBN = "BEJOBN";

        /// <summary>
        /// BEUPMJ.
        /// </summary>
        public const string BEUPMJ = "BEUPMJ";

        /// <summary>
        /// BEUPMT.
        /// </summary>
        public const string BEUPMT = "BEUPMT";

        /// <summary>
        /// BEYFUTDT1.
        /// </summary>
        public const string BEYFUTDT1 = "BEYFUTDT1";

        /// <summary>
        /// BEFUT6.
        /// </summary>
        public const string BEFUT6 = "BEFUT6";

        /// <summary>
        /// BEYT04.
        /// </summary>
        public const string BEYT04 = "BEYT04";

        /// <summary>
        /// BEYFLAG.
        /// </summary>
        public const string BEYFLAG = "BEYFLAG";

        /// <summary>
        /// BEYNUM1.
        /// </summary>
        public const string BEYNUM1 = "BEYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I834";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BEKCO", "BEKCO", JdeDataType.String, 10, true, true),
        new JdeField("BEDCT", "BEDCT", JdeDataType.String, 4, true, true),
        new JdeField("BEDOC", "BEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("BEI75INVNO", "BEI75INVNO", JdeDataType.String, 50, true, true),
        new JdeField("BEI75BOEXP", "BEI75BOEXP", JdeDataType.String, 80),
        new JdeField("BEI75BOEXD", "BEI75BOEXD", JdeDataType.Numeric),
        new JdeField("BEUSER", "BEUSER", JdeDataType.String, 20),
        new JdeField("BEPID", "BEPID", JdeDataType.String, 20),
        new JdeField("BEJOBN", "BEJOBN", JdeDataType.String, 20),
        new JdeField("BEUPMJ", "BEUPMJ", JdeDataType.Numeric),
        new JdeField("BEUPMT", "BEUPMT", JdeDataType.Numeric),
        new JdeField("BEYFUTDT1", "BEYFUTDT1", JdeDataType.Numeric),
        new JdeField("BEFUT6", "BEFUT6", JdeDataType.String, 60),
        new JdeField("BEYT04", "BEYT04", JdeDataType.String, 2),
        new JdeField("BEYFLAG", "BEYFLAG", JdeDataType.String, 2),
        new JdeField("BEYNUM1", "BEYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I834_0", "Primary Key on BEKCO, BEDCT, BEDOC, BEI75INVNO", new[] { "BEKCO", "BEDCT", "BEDOC", "BEI75INVNO" }, isUnique: true, isPrimaryKey: true)
    };
}
