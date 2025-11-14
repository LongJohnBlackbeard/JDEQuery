using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L920 - .
/// </summary>
public class F74L920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKL74ACIR.
        /// </summary>
        public const string TKL74ACIR = "TKL74ACIR";

        /// <summary>
        /// TKL74REFA.
        /// </summary>
        public const string TKL74REFA = "TKL74REFA";

        /// <summary>
        /// TKL74READ.
        /// </summary>
        public const string TKL74READ = "TKL74READ";

        /// <summary>
        /// TKL74GC.
        /// </summary>
        public const string TKL74GC = "TKL74GC";

        /// <summary>
        /// TKTORG.
        /// </summary>
        public const string TKTORG = "TKTORG";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKL74TX.
        /// </summary>
        public const string TKL74TX = "TKL74TX";

        /// <summary>
        /// TKL74TD.
        /// </summary>
        public const string TKL74TD = "TKL74TD";
    }

    /// <inheritdoc />
    public override string TableName => "F74L920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKL74ACIR", "TKL74ACIR", JdeDataType.String, 4, true, true),
        new JdeField("TKL74REFA", "TKL74REFA", JdeDataType.String, 60, true, true),
        new JdeField("TKL74READ", "TKL74READ", JdeDataType.String, 160),
        new JdeField("TKL74GC", "TKL74GC", JdeDataType.String, 4),
        new JdeField("TKTORG", "TKTORG", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKL74TX", "TKL74TX", JdeDataType.String, 2),
        new JdeField("TKL74TD", "TKL74TD", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L920_0", "Primary Key on TKL74ACIR, TKL74REFA", new[] { "TKL74ACIR", "TKL74REFA" }, isUnique: true, isPrimaryKey: true)
    };
}
