using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76VTART - .
/// </summary>
public class F76VTART : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRCO.
        /// </summary>
        public const string TRCO = "TRCO";

        /// <summary>
        /// TRTAX.
        /// </summary>
        public const string TRTAX = "TRTAX";

        /// <summary>
        /// TRTX2.
        /// </summary>
        public const string TRTX2 = "TRTX2";

        /// <summary>
        /// TRAN8.
        /// </summary>
        public const string TRAN8 = "TRAN8";

        /// <summary>
        /// TRALPH.
        /// </summary>
        public const string TRALPH = "TRALPH";

        /// <summary>
        /// TRDGJ.
        /// </summary>
        public const string TRDGJ = "TRDGJ";

        /// <summary>
        /// TRMT.
        /// </summary>
        public const string TRMT = "TRMT";

        /// <summary>
        /// TRFY.
        /// </summary>
        public const string TRFY = "TRFY";

        /// <summary>
        /// TRDCT.
        /// </summary>
        public const string TRDCT = "TRDCT";

        /// <summary>
        /// TRA201.
        /// </summary>
        public const string TRA201 = "TRA201";

        /// <summary>
        /// TRAG.
        /// </summary>
        public const string TRAG = "TRAG";

        /// <summary>
        /// TRPAAP.
        /// </summary>
        public const string TRPAAP = "TRPAAP";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRAJSY.
        /// </summary>
        public const string TRAJSY = "TRAJSY";
    }

    /// <inheritdoc />
    public override string TableName => "F76VTART";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRCO", "TRCO", JdeDataType.String, 10),
        new JdeField("TRTAX", "TRTAX", JdeDataType.String, 40),
        new JdeField("TRTX2", "TRTX2", JdeDataType.String, 40),
        new JdeField("TRAN8", "TRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TRALPH", "TRALPH", JdeDataType.String, 80),
        new JdeField("TRDGJ", "TRDGJ", JdeDataType.Numeric),
        new JdeField("TRMT", "TRMT", JdeDataType.Numeric, null, true, true),
        new JdeField("TRFY", "TRFY", JdeDataType.Numeric, null, true, true),
        new JdeField("TRDCT", "TRDCT", JdeDataType.String, 4),
        new JdeField("TRA201", "TRA201", JdeDataType.String, 4),
        new JdeField("TRAG", "TRAG", JdeDataType.Numeric),
        new JdeField("TRPAAP", "TRPAAP", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRAJSY", "TRAJSY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76VTART_0", "Primary Key on TRAN8, TRFY, TRMT", new[] { "TRAN8", "TRFY", "TRMT" }, isUnique: true, isPrimaryKey: true)
    };
}
