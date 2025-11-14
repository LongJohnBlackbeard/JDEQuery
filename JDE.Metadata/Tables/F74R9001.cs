using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9001 - .
/// </summary>
public class F74R9001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAOBJ.
        /// </summary>
        public const string CAOBJ = "CAOBJ";

        /// <summary>
        /// CASUB.
        /// </summary>
        public const string CASUB = "CASUB";

        /// <summary>
        /// CAR74CCG.
        /// </summary>
        public const string CAR74CCG = "CAR74CCG";

        /// <summary>
        /// CAR74CART.
        /// </summary>
        public const string CAR74CART = "CAR74CART";

        /// <summary>
        /// CAR74ACTY.
        /// </summary>
        public const string CAR74ACTY = "CAR74ACTY";

        /// <summary>
        /// CAR74CPA.
        /// </summary>
        public const string CAR74CPA = "CAR74CPA";

        /// <summary>
        /// CAR74CMA.
        /// </summary>
        public const string CAR74CMA = "CAR74CMA";

        /// <summary>
        /// CAR74CPVA.
        /// </summary>
        public const string CAR74CPVA = "CAR74CPVA";

        /// <summary>
        /// CAR74CMVA.
        /// </summary>
        public const string CAR74CMVA = "CAR74CMVA";

        /// <summary>
        /// CAR74CLOD.
        /// </summary>
        public const string CAR74CLOD = "CAR74CLOD";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAOBJ", "CAOBJ", JdeDataType.String, 12, true, true),
        new JdeField("CASUB", "CASUB", JdeDataType.String, 16, true, true),
        new JdeField("CAR74CCG", "CAR74CCG", JdeDataType.String, 20, true, true),
        new JdeField("CAR74CART", "CAR74CART", JdeDataType.String, 2),
        new JdeField("CAR74ACTY", "CAR74ACTY", JdeDataType.String, 2),
        new JdeField("CAR74CPA", "CAR74CPA", JdeDataType.String, 4),
        new JdeField("CAR74CMA", "CAR74CMA", JdeDataType.String, 4),
        new JdeField("CAR74CPVA", "CAR74CPVA", JdeDataType.String, 4),
        new JdeField("CAR74CMVA", "CAR74CMVA", JdeDataType.String, 4),
        new JdeField("CAR74CLOD", "CAR74CLOD", JdeDataType.Numeric),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9001_0", "Primary Key on CAOBJ, CASUB, CAR74CCG", new[] { "CAOBJ", "CASUB", "CAR74CCG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9001_2", "Index on CAOBJ, CASUB, CAR74CCG, SYS_NC00016$", new[] { "CAOBJ", "CASUB", "CAR74CCG", "SYS_NC00016$" })
    };
}
