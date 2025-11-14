using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0111 - .
/// </summary>
public class F74U0111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCU74UTR.
        /// </summary>
        public const string CCU74UTR = "CCU74UTR";

        /// <summary>
        /// CCU74TON.
        /// </summary>
        public const string CCU74TON = "CCU74TON";

        /// <summary>
        /// CCU74TOR.
        /// </summary>
        public const string CCU74TOR = "CCU74TOR";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCU74UTR", "CCU74UTR", JdeDataType.Numeric),
        new JdeField("CCU74TON", "CCU74TON", JdeDataType.Numeric),
        new JdeField("CCU74TOR", "CCU74TOR", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0111_0", "Primary Key on CCCO", new[] { "CCCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0111_2", "Index on CCU74UTR", new[] { "CCU74UTR" })
    };
}
