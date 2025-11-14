using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4013 - .
/// </summary>
public class F4013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SXXRTC.
        /// </summary>
        public const string SXXRTC = "SXXRTC";

        /// <summary>
        /// SXXRVF.
        /// </summary>
        public const string SXXRVF = "SXXRVF";

        /// <summary>
        /// SXXRVT.
        /// </summary>
        public const string SXXRVT = "SXXRVT";

        /// <summary>
        /// SXEDF1.
        /// </summary>
        public const string SXEDF1 = "SXEDF1";

        /// <summary>
        /// SXDESC.
        /// </summary>
        public const string SXDESC = "SXDESC";

        /// <summary>
        /// SXUSER.
        /// </summary>
        public const string SXUSER = "SXUSER";

        /// <summary>
        /// SXPID.
        /// </summary>
        public const string SXPID = "SXPID";

        /// <summary>
        /// SXJOBN.
        /// </summary>
        public const string SXJOBN = "SXJOBN";

        /// <summary>
        /// SXUPMJ.
        /// </summary>
        public const string SXUPMJ = "SXUPMJ";

        /// <summary>
        /// SXTDAY.
        /// </summary>
        public const string SXTDAY = "SXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SXXRTC", "SXXRTC", JdeDataType.String, 4, true, true),
        new JdeField("SXXRVF", "SXXRVF", JdeDataType.String, 60, true, true),
        new JdeField("SXXRVT", "SXXRVT", JdeDataType.String, 60, true, true),
        new JdeField("SXEDF1", "SXEDF1", JdeDataType.String, 2, true, true),
        new JdeField("SXDESC", "SXDESC", JdeDataType.String, 60),
        new JdeField("SXUSER", "SXUSER", JdeDataType.String, 20),
        new JdeField("SXPID", "SXPID", JdeDataType.String, 20),
        new JdeField("SXJOBN", "SXJOBN", JdeDataType.String, 20),
        new JdeField("SXUPMJ", "SXUPMJ", JdeDataType.Numeric),
        new JdeField("SXTDAY", "SXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4013_0", "Primary Key on SXXRVF, SXXRTC, SXXRVT, SXEDF1", new[] { "SXXRVF", "SXXRTC", "SXXRVT", "SXEDF1" }, isUnique: true, isPrimaryKey: true)
    };
}
