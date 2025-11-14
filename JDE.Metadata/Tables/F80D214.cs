using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D214 - .
/// </summary>
public class F80D214 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VRPRDJ.
        /// </summary>
        public const string VRPRDJ = "VRPRDJ";

        /// <summary>
        /// VRMCU.
        /// </summary>
        public const string VRMCU = "VRMCU";

        /// <summary>
        /// VRITM.
        /// </summary>
        public const string VRITM = "VRITM";

        /// <summary>
        /// VRVARN.
        /// </summary>
        public const string VRVARN = "VRVARN";

        /// <summary>
        /// VRBORDCT.
        /// </summary>
        public const string VRBORDCT = "VRBORDCT";

        /// <summary>
        /// VRUSER.
        /// </summary>
        public const string VRUSER = "VRUSER";

        /// <summary>
        /// VRPID.
        /// </summary>
        public const string VRPID = "VRPID";

        /// <summary>
        /// VRMKEY.
        /// </summary>
        public const string VRMKEY = "VRMKEY";

        /// <summary>
        /// VRUTIME.
        /// </summary>
        public const string VRUTIME = "VRUTIME";

        /// <summary>
        /// VRURCD.
        /// </summary>
        public const string VRURCD = "VRURCD";

        /// <summary>
        /// VRURDT.
        /// </summary>
        public const string VRURDT = "VRURDT";

        /// <summary>
        /// VRURAT.
        /// </summary>
        public const string VRURAT = "VRURAT";

        /// <summary>
        /// VRURAB.
        /// </summary>
        public const string VRURAB = "VRURAB";

        /// <summary>
        /// VRURRF.
        /// </summary>
        public const string VRURRF = "VRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D214";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VRPRDJ", "VRPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VRMCU", "VRMCU", JdeDataType.String, 24, true, true),
        new JdeField("VRITM", "VRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("VRVARN", "VRVARN", JdeDataType.Numeric),
        new JdeField("VRBORDCT", "VRBORDCT", JdeDataType.Numeric),
        new JdeField("VRUSER", "VRUSER", JdeDataType.String, 20),
        new JdeField("VRPID", "VRPID", JdeDataType.String, 20),
        new JdeField("VRMKEY", "VRMKEY", JdeDataType.String, 30),
        new JdeField("VRUTIME", "VRUTIME", JdeDataType.Date),
        new JdeField("VRURCD", "VRURCD", JdeDataType.String, 4),
        new JdeField("VRURDT", "VRURDT", JdeDataType.Numeric),
        new JdeField("VRURAT", "VRURAT", JdeDataType.Numeric),
        new JdeField("VRURAB", "VRURAB", JdeDataType.Numeric),
        new JdeField("VRURRF", "VRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D214_0", "Primary Key on VRPRDJ, VRMCU, VRITM", new[] { "VRPRDJ", "VRMCU", "VRITM" }, isUnique: true, isPrimaryKey: true)
    };
}
