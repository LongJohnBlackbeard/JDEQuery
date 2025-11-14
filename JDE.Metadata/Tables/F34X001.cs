using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X001 - .
/// </summary>
public class F34X001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MC34XCNM.
        /// </summary>
        public const string MC34XCNM = "MC34XCNM";

        /// <summary>
        /// MC34XCDC.
        /// </summary>
        public const string MC34XCDC = "MC34XCDC";

        /// <summary>
        /// MCMSGT.
        /// </summary>
        public const string MCMSGT = "MCMSGT";

        /// <summary>
        /// MC34XMTD.
        /// </summary>
        public const string MC34XMTD = "MC34XMTD";

        /// <summary>
        /// MCTORG.
        /// </summary>
        public const string MCTORG = "MCTORG";

        /// <summary>
        /// MC34XMGP.
        /// </summary>
        public const string MC34XMGP = "MC34XMGP";

        /// <summary>
        /// MC34XTL1.
        /// </summary>
        public const string MC34XTL1 = "MC34XTL1";

        /// <summary>
        /// MC34XTL2.
        /// </summary>
        public const string MC34XTL2 = "MC34XTL2";

        /// <summary>
        /// MC34XFC1.
        /// </summary>
        public const string MC34XFC1 = "MC34XFC1";

        /// <summary>
        /// MC34XFN1.
        /// </summary>
        public const string MC34XFN1 = "MC34XFN1";

        /// <summary>
        /// MC34XFS1.
        /// </summary>
        public const string MC34XFS1 = "MC34XFS1";

        /// <summary>
        /// MC34XFDJ.
        /// </summary>
        public const string MC34XFDJ = "MC34XFDJ";

        /// <summary>
        /// MCPID.
        /// </summary>
        public const string MCPID = "MCPID";

        /// <summary>
        /// MCUSER.
        /// </summary>
        public const string MCUSER = "MCUSER";

        /// <summary>
        /// MCJOBN.
        /// </summary>
        public const string MCJOBN = "MCJOBN";

        /// <summary>
        /// MCUPMJ.
        /// </summary>
        public const string MCUPMJ = "MCUPMJ";

        /// <summary>
        /// MCUPMT.
        /// </summary>
        public const string MCUPMT = "MCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F34X001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MC34XCNM", "MC34XCNM", JdeDataType.String, 20, true, true),
        new JdeField("MC34XCDC", "MC34XCDC", JdeDataType.String, 60),
        new JdeField("MCMSGT", "MCMSGT", JdeDataType.String, 2, true, true),
        new JdeField("MC34XMTD", "MC34XMTD", JdeDataType.String, 60),
        new JdeField("MCTORG", "MCTORG", JdeDataType.String, 20),
        new JdeField("MC34XMGP", "MC34XMGP", JdeDataType.Numeric),
        new JdeField("MC34XTL1", "MC34XTL1", JdeDataType.Numeric),
        new JdeField("MC34XTL2", "MC34XTL2", JdeDataType.Numeric),
        new JdeField("MC34XFC1", "MC34XFC1", JdeDataType.String, 2),
        new JdeField("MC34XFN1", "MC34XFN1", JdeDataType.Numeric),
        new JdeField("MC34XFS1", "MC34XFS1", JdeDataType.String, 80),
        new JdeField("MC34XFDJ", "MC34XFDJ", JdeDataType.Numeric),
        new JdeField("MCPID", "MCPID", JdeDataType.String, 20),
        new JdeField("MCUSER", "MCUSER", JdeDataType.String, 20),
        new JdeField("MCJOBN", "MCJOBN", JdeDataType.String, 20),
        new JdeField("MCUPMJ", "MCUPMJ", JdeDataType.Numeric),
        new JdeField("MCUPMT", "MCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X001_0", "Primary Key on MC34XCNM, MCMSGT", new[] { "MC34XCNM", "MCMSGT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34X001_2", "Unique Index on MC34XCNM, MC34XMGP", new[] { "MC34XCNM", "MC34XMGP" }, isUnique: true),
        new JdeIndex("F34X001_3", "Index on MC34XCNM", new[] { "MC34XCNM" })
    };
}
