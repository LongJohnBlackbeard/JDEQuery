using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39041 - .
/// </summary>
public class F39041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCCO.
        /// </summary>
        public const string VCCO = "VCCO";

        /// <summary>
        /// VCITPL.
        /// </summary>
        public const string VCITPL = "VCITPL";

        /// <summary>
        /// VCITM.
        /// </summary>
        public const string VCITM = "VCITM";

        /// <summary>
        /// VCUOM.
        /// </summary>
        public const string VCUOM = "VCUOM";

        /// <summary>
        /// VCGLPT.
        /// </summary>
        public const string VCGLPT = "VCGLPT";

        /// <summary>
        /// VCSVDT.
        /// </summary>
        public const string VCSVDT = "VCSVDT";

        /// <summary>
        /// VCSVFU.
        /// </summary>
        public const string VCSVFU = "VCSVFU";

        /// <summary>
        /// VCSVF1.
        /// </summary>
        public const string VCSVF1 = "VCSVF1";

        /// <summary>
        /// VCSVF2.
        /// </summary>
        public const string VCSVF2 = "VCSVF2";

        /// <summary>
        /// VCSVF3.
        /// </summary>
        public const string VCSVF3 = "VCSVF3";

        /// <summary>
        /// VCSVF4.
        /// </summary>
        public const string VCSVF4 = "VCSVF4";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCTDAY.
        /// </summary>
        public const string VCTDAY = "VCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F39041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCCO", "VCCO", JdeDataType.String, 10, true, true),
        new JdeField("VCITPL", "VCITPL", JdeDataType.String, 20, true, true),
        new JdeField("VCITM", "VCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("VCUOM", "VCUOM", JdeDataType.String, 4),
        new JdeField("VCGLPT", "VCGLPT", JdeDataType.String, 8),
        new JdeField("VCSVDT", "VCSVDT", JdeDataType.Numeric),
        new JdeField("VCSVFU", "VCSVFU", JdeDataType.String, 4),
        new JdeField("VCSVF1", "VCSVF1", JdeDataType.String, 2),
        new JdeField("VCSVF2", "VCSVF2", JdeDataType.String, 2),
        new JdeField("VCSVF3", "VCSVF3", JdeDataType.String, 2),
        new JdeField("VCSVF4", "VCSVF4", JdeDataType.String, 2),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCTDAY", "VCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39041_0", "Primary Key on VCCO, VCITPL, VCITM", new[] { "VCCO", "VCITPL", "VCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
