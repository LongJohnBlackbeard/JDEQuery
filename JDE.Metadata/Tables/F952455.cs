using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952455 - .
/// </summary>
public class F952455 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCWOBNM.
        /// </summary>
        public const string SCWOBNM = "SCWOBNM";

        /// <summary>
        /// SCWOUSER.
        /// </summary>
        public const string SCWOUSER = "SCWOUSER";

        /// <summary>
        /// SCWOOBNMS.
        /// </summary>
        public const string SCWOOBNMS = "SCWOOBNMS";

        /// <summary>
        /// SCWOOBNML.
        /// </summary>
        public const string SCWOOBNML = "SCWOOBNML";

        /// <summary>
        /// SCSY.
        /// </summary>
        public const string SCSY = "SCSY";

        /// <summary>
        /// SCOMRBLOB.
        /// </summary>
        public const string SCOMRBLOB = "SCOMRBLOB";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCWOUTIME.
        /// </summary>
        public const string SCWOUTIME = "SCWOUTIME";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCMKEY.
        /// </summary>
        public const string SCMKEY = "SCMKEY";

        /// <summary>
        /// SCWOFU1.
        /// </summary>
        public const string SCWOFU1 = "SCWOFU1";

        /// <summary>
        /// SCWOFU2.
        /// </summary>
        public const string SCWOFU2 = "SCWOFU2";

        /// <summary>
        /// SCWOFU3.
        /// </summary>
        public const string SCWOFU3 = "SCWOFU3";

        /// <summary>
        /// SCWOFU4.
        /// </summary>
        public const string SCWOFU4 = "SCWOFU4";

        /// <summary>
        /// SCWOFU5.
        /// </summary>
        public const string SCWOFU5 = "SCWOFU5";

        /// <summary>
        /// SCWOFU6.
        /// </summary>
        public const string SCWOFU6 = "SCWOFU6";

        /// <summary>
        /// SCWOFU7.
        /// </summary>
        public const string SCWOFU7 = "SCWOFU7";

        /// <summary>
        /// SCWOFU8.
        /// </summary>
        public const string SCWOFU8 = "SCWOFU8";

        /// <summary>
        /// SCWOFU9.
        /// </summary>
        public const string SCWOFU9 = "SCWOFU9";

        /// <summary>
        /// SCWOFU10.
        /// </summary>
        public const string SCWOFU10 = "SCWOFU10";
    }

    /// <inheritdoc />
    public override string TableName => "F952455";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCWOBNM", "SCWOBNM", JdeDataType.String, 60, true, true),
        new JdeField("SCWOUSER", "SCWOUSER", JdeDataType.String, 60, true, true),
        new JdeField("SCWOOBNMS", "SCWOOBNMS", JdeDataType.String, 100),
        new JdeField("SCWOOBNML", "SCWOOBNML", JdeDataType.String, 400),
        new JdeField("SCSY", "SCSY", JdeDataType.String, 8),
        new JdeField("SCOMRBLOB", "SCOMRBLOB", JdeDataType.String),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCWOUTIME", "SCWOUTIME", JdeDataType.Date),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCMKEY", "SCMKEY", JdeDataType.String, 30),
        new JdeField("SCWOFU1", "SCWOFU1", JdeDataType.String, 2),
        new JdeField("SCWOFU2", "SCWOFU2", JdeDataType.String, 2),
        new JdeField("SCWOFU3", "SCWOFU3", JdeDataType.String, 100),
        new JdeField("SCWOFU4", "SCWOFU4", JdeDataType.String, 100),
        new JdeField("SCWOFU5", "SCWOFU5", JdeDataType.String, 200),
        new JdeField("SCWOFU6", "SCWOFU6", JdeDataType.String, 200),
        new JdeField("SCWOFU7", "SCWOFU7", JdeDataType.Numeric),
        new JdeField("SCWOFU8", "SCWOFU8", JdeDataType.Numeric),
        new JdeField("SCWOFU9", "SCWOFU9", JdeDataType.Date),
        new JdeField("SCWOFU10", "SCWOFU10", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952455_0", "Primary Key on SCWOBNM, SCWOUSER", new[] { "SCWOBNM", "SCWOUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F952455_2", "Unique Index on SCWOOBNMS, SCWOBNM, SCWOUSER", new[] { "SCWOOBNMS", "SCWOBNM", "SCWOUSER" }, isUnique: true)
    };
}
