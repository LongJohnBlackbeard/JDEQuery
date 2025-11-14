using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46R070 - .
/// </summary>
public class F46R070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECEPCHDR.
        /// </summary>
        public const string ECEPCHDR = "ECEPCHDR";

        /// <summary>
        /// ECKCOO.
        /// </summary>
        public const string ECKCOO = "ECKCOO";

        /// <summary>
        /// ECAN8.
        /// </summary>
        public const string ECAN8 = "ECAN8";

        /// <summary>
        /// ECEPCCPD.
        /// </summary>
        public const string ECEPCCPD = "ECEPCCPD";

        /// <summary>
        /// ECURCD.
        /// </summary>
        public const string ECURCD = "ECURCD";

        /// <summary>
        /// ECURDT.
        /// </summary>
        public const string ECURDT = "ECURDT";

        /// <summary>
        /// ECURAT.
        /// </summary>
        public const string ECURAT = "ECURAT";

        /// <summary>
        /// ECURAB.
        /// </summary>
        public const string ECURAB = "ECURAB";

        /// <summary>
        /// ECURRF.
        /// </summary>
        public const string ECURRF = "ECURRF";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECUUPMJ.
        /// </summary>
        public const string ECUUPMJ = "ECUUPMJ";

        /// <summary>
        /// ECMKEY.
        /// </summary>
        public const string ECMKEY = "ECMKEY";

        /// <summary>
        /// ECSVRNAME.
        /// </summary>
        public const string ECSVRNAME = "ECSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46R070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECEPCHDR", "ECEPCHDR", JdeDataType.String, 4, true, true),
        new JdeField("ECKCOO", "ECKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ECAN8", "ECAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ECEPCCPD", "ECEPCCPD", JdeDataType.Numeric),
        new JdeField("ECURCD", "ECURCD", JdeDataType.String, 4),
        new JdeField("ECURDT", "ECURDT", JdeDataType.Numeric),
        new JdeField("ECURAT", "ECURAT", JdeDataType.Numeric),
        new JdeField("ECURAB", "ECURAB", JdeDataType.Numeric),
        new JdeField("ECURRF", "ECURRF", JdeDataType.String, 30),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECUUPMJ", "ECUUPMJ", JdeDataType.Date),
        new JdeField("ECMKEY", "ECMKEY", JdeDataType.String, 30),
        new JdeField("ECSVRNAME", "ECSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46R070_0", "Primary Key on ECEPCHDR, ECKCOO, ECAN8", new[] { "ECEPCHDR", "ECKCOO", "ECAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
