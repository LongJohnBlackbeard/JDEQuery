using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I016 - .
/// </summary>
public class F75I016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSI75CHTY.
        /// </summary>
        public const string CSI75CHTY = "CSI75CHTY";

        /// <summary>
        /// CSI75CHCO.
        /// </summary>
        public const string CSI75CHCO = "CSI75CHCO";

        /// <summary>
        /// CSI75CHNB.
        /// </summary>
        public const string CSI75CHNB = "CSI75CHNB";

        /// <summary>
        /// CSI75CHDS.
        /// </summary>
        public const string CSI75CHDS = "CSI75CHDS";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSI75CHTY", "CSI75CHTY", JdeDataType.String, 6, true, true),
        new JdeField("CSI75CHCO", "CSI75CHCO", JdeDataType.String, 12),
        new JdeField("CSI75CHNB", "CSI75CHNB", JdeDataType.String, 40, true, true),
        new JdeField("CSI75CHDS", "CSI75CHDS", JdeDataType.String, 60),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I016_0", "Primary Key on CSI75CHTY, CSI75CHNB", new[] { "CSI75CHTY", "CSI75CHNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I016_2", "Unique Index on CSI75CHTY, CSI75CHCO", new[] { "CSI75CHTY", "CSI75CHCO" }, isUnique: true)
    };
}
