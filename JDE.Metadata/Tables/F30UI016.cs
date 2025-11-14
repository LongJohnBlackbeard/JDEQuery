using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI016 - .
/// </summary>
public class F30UI016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BEBOML.
        /// </summary>
        public const string BEBOML = "BEBOML";

        /// <summary>
        /// BEKIT.
        /// </summary>
        public const string BEKIT = "BEKIT";

        /// <summary>
        /// BEMCU.
        /// </summary>
        public const string BEMCU = "BEMCU";

        /// <summary>
        /// BEBQTY.
        /// </summary>
        public const string BEBQTY = "BEBQTY";

        /// <summary>
        /// BEUOM.
        /// </summary>
        public const string BEUOM = "BEUOM";

        /// <summary>
        /// BETBM.
        /// </summary>
        public const string BETBM = "BETBM";

        /// <summary>
        /// BEBREV.
        /// </summary>
        public const string BEBREV = "BEBREV";

        /// <summary>
        /// BEOITM.
        /// </summary>
        public const string BEOITM = "BEOITM";

        /// <summary>
        /// BEMMCU.
        /// </summary>
        public const string BEMMCU = "BEMMCU";

        /// <summary>
        /// BEITM.
        /// </summary>
        public const string BEITM = "BEITM";

        /// <summary>
        /// BELITM.
        /// </summary>
        public const string BELITM = "BELITM";

        /// <summary>
        /// BECMCU.
        /// </summary>
        public const string BECMCU = "BECMCU";

        /// <summary>
        /// BEQNTY.
        /// </summary>
        public const string BEQNTY = "BEQNTY";

        /// <summary>
        /// BEEXQTY.
        /// </summary>
        public const string BEEXQTY = "BEEXQTY";

        /// <summary>
        /// BEUM.
        /// </summary>
        public const string BEUM = "BEUM";

        /// <summary>
        /// BEOPSQ.
        /// </summary>
        public const string BEOPSQ = "BEOPSQ";

        /// <summary>
        /// BESTKT.
        /// </summary>
        public const string BESTKT = "BESTKT";

        /// <summary>
        /// BELNTY.
        /// </summary>
        public const string BELNTY = "BELNTY";

        /// <summary>
        /// BEEFFF.
        /// </summary>
        public const string BEEFFF = "BEEFFF";

        /// <summary>
        /// BEEFFT.
        /// </summary>
        public const string BEEFFT = "BEEFFT";

        /// <summary>
        /// BEMATH01.
        /// </summary>
        public const string BEMATH01 = "BEMATH01";

        /// <summary>
        /// BEMATH02.
        /// </summary>
        public const string BEMATH02 = "BEMATH02";

        /// <summary>
        /// BEUKID.
        /// </summary>
        public const string BEUKID = "BEUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BEBOML", "BEBOML", JdeDataType.Numeric),
        new JdeField("BEKIT", "BEKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BEMCU", "BEMCU", JdeDataType.String, 24, true, true),
        new JdeField("BEBQTY", "BEBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BEUOM", "BEUOM", JdeDataType.String, 4, true, true),
        new JdeField("BETBM", "BETBM", JdeDataType.String, 6, true, true),
        new JdeField("BEBREV", "BEBREV", JdeDataType.String, 6, true, true),
        new JdeField("BEOITM", "BEOITM", JdeDataType.Numeric),
        new JdeField("BEMMCU", "BEMMCU", JdeDataType.String, 24),
        new JdeField("BEITM", "BEITM", JdeDataType.Numeric),
        new JdeField("BELITM", "BELITM", JdeDataType.String, 50),
        new JdeField("BECMCU", "BECMCU", JdeDataType.String, 24),
        new JdeField("BEQNTY", "BEQNTY", JdeDataType.Numeric),
        new JdeField("BEEXQTY", "BEEXQTY", JdeDataType.Numeric),
        new JdeField("BEUM", "BEUM", JdeDataType.String, 4),
        new JdeField("BEOPSQ", "BEOPSQ", JdeDataType.Numeric),
        new JdeField("BESTKT", "BESTKT", JdeDataType.String, 2),
        new JdeField("BELNTY", "BELNTY", JdeDataType.String, 4),
        new JdeField("BEEFFF", "BEEFFF", JdeDataType.Numeric),
        new JdeField("BEEFFT", "BEEFFT", JdeDataType.Numeric),
        new JdeField("BEMATH01", "BEMATH01", JdeDataType.Numeric),
        new JdeField("BEMATH02", "BEMATH02", JdeDataType.Numeric),
        new JdeField("BEUKID", "BEUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI016_0", "Primary Key on BEKIT, BEMCU, BEBQTY, BEUOM, BETBM, BEBREV, BEUKID", new[] { "BEKIT", "BEMCU", "BEBQTY", "BEUOM", "BETBM", "BEBREV", "BEUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI016_2", "Index on BEBOML, BEKIT, BEMCU, BEBQTY, BETBM", new[] { "BEBOML", "BEKIT", "BEMCU", "BEBQTY", "BETBM" }),
        new JdeIndex("F30UI016_3", "Index on BEKIT, BEMCU, BEBQTY, BETBM, BEMATH01", new[] { "BEKIT", "BEMCU", "BEBQTY", "BETBM", "BEMATH01" }),
        new JdeIndex("F30UI016_4", "Index on BEKIT, BEMCU, BEBQTY, BETBM, BEMATH02", new[] { "BEKIT", "BEMCU", "BEBQTY", "BETBM", "BEMATH02" })
    };
}
