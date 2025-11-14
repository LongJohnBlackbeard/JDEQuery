using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3312 - .
/// </summary>
public class F3312 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWCAPM.
        /// </summary>
        public const string CWCAPM = "CWCAPM";

        /// <summary>
        /// CWMCU.
        /// </summary>
        public const string CWMCU = "CWMCU";

        /// <summary>
        /// CWITM.
        /// </summary>
        public const string CWITM = "CWITM";

        /// <summary>
        /// CWMMCU.
        /// </summary>
        public const string CWMMCU = "CWMMCU";

        /// <summary>
        /// CWDRQJ.
        /// </summary>
        public const string CWDRQJ = "CWDRQJ";

        /// <summary>
        /// CWTRQT.
        /// </summary>
        public const string CWTRQT = "CWTRQT";

        /// <summary>
        /// CWUORG.
        /// </summary>
        public const string CWUORG = "CWUORG";

        /// <summary>
        /// CWUM.
        /// </summary>
        public const string CWUM = "CWUM";

        /// <summary>
        /// CWUNTY.
        /// </summary>
        public const string CWUNTY = "CWUNTY";

        /// <summary>
        /// CWDOCO.
        /// </summary>
        public const string CWDOCO = "CWDOCO";

        /// <summary>
        /// CWDCTO.
        /// </summary>
        public const string CWDCTO = "CWDCTO";

        /// <summary>
        /// CWUKID.
        /// </summary>
        public const string CWUKID = "CWUKID";

        /// <summary>
        /// CWWMCU.
        /// </summary>
        public const string CWWMCU = "CWWMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F3312";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWCAPM", "CWCAPM", JdeDataType.String, 2),
        new JdeField("CWMCU", "CWMCU", JdeDataType.String, 24),
        new JdeField("CWITM", "CWITM", JdeDataType.Numeric),
        new JdeField("CWMMCU", "CWMMCU", JdeDataType.String, 24),
        new JdeField("CWDRQJ", "CWDRQJ", JdeDataType.Numeric),
        new JdeField("CWTRQT", "CWTRQT", JdeDataType.Numeric),
        new JdeField("CWUORG", "CWUORG", JdeDataType.Numeric),
        new JdeField("CWUM", "CWUM", JdeDataType.String, 4),
        new JdeField("CWUNTY", "CWUNTY", JdeDataType.String, 2),
        new JdeField("CWDOCO", "CWDOCO", JdeDataType.Numeric),
        new JdeField("CWDCTO", "CWDCTO", JdeDataType.String, 4),
        new JdeField("CWUKID", "CWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CWWMCU", "CWWMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3312_0", "Primary Key on CWUKID", new[] { "CWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3312_1", "Index on CWCAPM, CWMMCU, CWMCU, CWWMCU, CWUM, CWDRQJ", new[] { "CWCAPM", "CWMMCU", "CWMCU", "CWWMCU", "CWUM", "CWDRQJ" }),
        new JdeIndex("F3312_2", "Index on CWCAPM, CWMCU, CWWMCU, CWUM, CWDRQJ, SYS_NC00014$", new[] { "CWCAPM", "CWMCU", "CWWMCU", "CWUM", "CWDRQJ", "SYS_NC00014$" })
    };
}
