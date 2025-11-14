using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4093 - .
/// </summary>
public class F4093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDGPTY.
        /// </summary>
        public const string GDGPTY = "GDGPTY";

        /// <summary>
        /// GDGPC.
        /// </summary>
        public const string GDGPC = "GDGPC";

        /// <summary>
        /// GDGPC1.
        /// </summary>
        public const string GDGPC1 = "GDGPC1";

        /// <summary>
        /// GDGPC2.
        /// </summary>
        public const string GDGPC2 = "GDGPC2";

        /// <summary>
        /// GDGPC3.
        /// </summary>
        public const string GDGPC3 = "GDGPC3";

        /// <summary>
        /// GDGPC4.
        /// </summary>
        public const string GDGPC4 = "GDGPC4";

        /// <summary>
        /// GDGPC5.
        /// </summary>
        public const string GDGPC5 = "GDGPC5";

        /// <summary>
        /// GDGPC6.
        /// </summary>
        public const string GDGPC6 = "GDGPC6";

        /// <summary>
        /// GDGPC7.
        /// </summary>
        public const string GDGPC7 = "GDGPC7";

        /// <summary>
        /// GDGPC8.
        /// </summary>
        public const string GDGPC8 = "GDGPC8";

        /// <summary>
        /// GDGPC9.
        /// </summary>
        public const string GDGPC9 = "GDGPC9";

        /// <summary>
        /// GDGPC10.
        /// </summary>
        public const string GDGPC10 = "GDGPC10";

        /// <summary>
        /// GDBPRC.
        /// </summary>
        public const string GDBPRC = "GDBPRC";
    }

    /// <inheritdoc />
    public override string TableName => "F4093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDGPTY", "GDGPTY", JdeDataType.String, 2, true, true),
        new JdeField("GDGPC", "GDGPC", JdeDataType.String, 16, true, true),
        new JdeField("GDGPC1", "GDGPC1", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC2", "GDGPC2", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC3", "GDGPC3", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC4", "GDGPC4", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC5", "GDGPC5", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC6", "GDGPC6", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC7", "GDGPC7", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC8", "GDGPC8", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC9", "GDGPC9", JdeDataType.String, 12, true, true),
        new JdeField("GDGPC10", "GDGPC10", JdeDataType.String, 12, true, true),
        new JdeField("GDBPRC", "GDBPRC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4093_0", "Primary Key on GDGPTY, GDGPC, GDGPC1, GDGPC2, GDGPC3, GDGPC4, GDGPC5, GDGPC6, GDGPC7, GDGPC8, GDGPC9, GDGPC10", new[] { "GDGPTY", "GDGPC", "GDGPC1", "GDGPC2", "GDGPC3", "GDGPC4", "GDGPC5", "GDGPC6", "GDGPC7", "GDGPC8", "GDGPC9", "GDGPC10" }, isUnique: true, isPrimaryKey: true)
    };
}
