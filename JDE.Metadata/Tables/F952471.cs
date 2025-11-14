using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952471 - .
/// </summary>
public class F952471 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XMWOBNM.
        /// </summary>
        public const string XMWOBNM = "XMWOBNM";

        /// <summary>
        /// XMWOUSER.
        /// </summary>
        public const string XMWOUSER = "XMWOUSER";

        /// <summary>
        /// XMXMLTYPE.
        /// </summary>
        public const string XMXMLTYPE = "XMXMLTYPE";

        /// <summary>
        /// XMWOCAT.
        /// </summary>
        public const string XMWOCAT = "XMWOCAT";

        /// <summary>
        /// XMWOOBNMS.
        /// </summary>
        public const string XMWOOBNMS = "XMWOOBNMS";

        /// <summary>
        /// XMWOOBNML.
        /// </summary>
        public const string XMWOOBNML = "XMWOOBNML";

        /// <summary>
        /// XMOMRBLOB.
        /// </summary>
        public const string XMOMRBLOB = "XMOMRBLOB";

        /// <summary>
        /// XMOBNM.
        /// </summary>
        public const string XMOBNM = "XMOBNM";

        /// <summary>
        /// XMFMNM.
        /// </summary>
        public const string XMFMNM = "XMFMNM";

        /// <summary>
        /// XMSFMNM.
        /// </summary>
        public const string XMSFMNM = "XMSFMNM";

        /// <summary>
        /// XMVERS.
        /// </summary>
        public const string XMVERS = "XMVERS";

        /// <summary>
        /// XMUSER.
        /// </summary>
        public const string XMUSER = "XMUSER";

        /// <summary>
        /// XMMKEY.
        /// </summary>
        public const string XMMKEY = "XMMKEY";

        /// <summary>
        /// XMWOUTIME.
        /// </summary>
        public const string XMWOUTIME = "XMWOUTIME";

        /// <summary>
        /// XMPID.
        /// </summary>
        public const string XMPID = "XMPID";

        /// <summary>
        /// XMWOFU1.
        /// </summary>
        public const string XMWOFU1 = "XMWOFU1";

        /// <summary>
        /// XMWOFU2.
        /// </summary>
        public const string XMWOFU2 = "XMWOFU2";

        /// <summary>
        /// XMWOFU3.
        /// </summary>
        public const string XMWOFU3 = "XMWOFU3";

        /// <summary>
        /// XMWOFU4.
        /// </summary>
        public const string XMWOFU4 = "XMWOFU4";

        /// <summary>
        /// XMWOFU5.
        /// </summary>
        public const string XMWOFU5 = "XMWOFU5";

        /// <summary>
        /// XMWOFU6.
        /// </summary>
        public const string XMWOFU6 = "XMWOFU6";

        /// <summary>
        /// XMWOFU7.
        /// </summary>
        public const string XMWOFU7 = "XMWOFU7";

        /// <summary>
        /// XMWOFU8.
        /// </summary>
        public const string XMWOFU8 = "XMWOFU8";

        /// <summary>
        /// XMWOFU9.
        /// </summary>
        public const string XMWOFU9 = "XMWOFU9";

        /// <summary>
        /// XMWOFU10.
        /// </summary>
        public const string XMWOFU10 = "XMWOFU10";
    }

    /// <inheritdoc />
    public override string TableName => "F952471";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XMWOBNM", "XMWOBNM", JdeDataType.String, 60, true, true),
        new JdeField("XMWOUSER", "XMWOUSER", JdeDataType.String, 60, true, true),
        new JdeField("XMXMLTYPE", "XMXMLTYPE", JdeDataType.String, 40, true, true),
        new JdeField("XMWOCAT", "XMWOCAT", JdeDataType.String, 20),
        new JdeField("XMWOOBNMS", "XMWOOBNMS", JdeDataType.String, 100),
        new JdeField("XMWOOBNML", "XMWOOBNML", JdeDataType.String, 400),
        new JdeField("XMOMRBLOB", "XMOMRBLOB", JdeDataType.String),
        new JdeField("XMOBNM", "XMOBNM", JdeDataType.String, 20),
        new JdeField("XMFMNM", "XMFMNM", JdeDataType.String, 20),
        new JdeField("XMSFMNM", "XMSFMNM", JdeDataType.String, 60),
        new JdeField("XMVERS", "XMVERS", JdeDataType.String, 20),
        new JdeField("XMUSER", "XMUSER", JdeDataType.String, 20),
        new JdeField("XMMKEY", "XMMKEY", JdeDataType.String, 30),
        new JdeField("XMWOUTIME", "XMWOUTIME", JdeDataType.Date),
        new JdeField("XMPID", "XMPID", JdeDataType.String, 20),
        new JdeField("XMWOFU1", "XMWOFU1", JdeDataType.String, 2),
        new JdeField("XMWOFU2", "XMWOFU2", JdeDataType.String, 2),
        new JdeField("XMWOFU3", "XMWOFU3", JdeDataType.String, 100),
        new JdeField("XMWOFU4", "XMWOFU4", JdeDataType.String, 100),
        new JdeField("XMWOFU5", "XMWOFU5", JdeDataType.String, 200),
        new JdeField("XMWOFU6", "XMWOFU6", JdeDataType.String, 200),
        new JdeField("XMWOFU7", "XMWOFU7", JdeDataType.Numeric),
        new JdeField("XMWOFU8", "XMWOFU8", JdeDataType.Numeric),
        new JdeField("XMWOFU9", "XMWOFU9", JdeDataType.Date),
        new JdeField("XMWOFU10", "XMWOFU10", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952471_0", "Primary Key on XMWOBNM, XMWOUSER, XMXMLTYPE", new[] { "XMWOBNM", "XMWOUSER", "XMXMLTYPE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F952471_3", "Unique Index on XMWOOBNMS, XMWOUSER, XMOBNM, XMFMNM, XMVERS, XMXMLTYPE", new[] { "XMWOOBNMS", "XMWOUSER", "XMOBNM", "XMFMNM", "XMVERS", "XMXMLTYPE" }, isUnique: true)
    };
}
