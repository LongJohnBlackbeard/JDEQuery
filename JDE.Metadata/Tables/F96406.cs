using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96406 - .
/// </summary>
public class F96406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STESUP.
        /// </summary>
        public const string STESUP = "STESUP";

        /// <summary>
        /// STSUTYPE.
        /// </summary>
        public const string STSUTYPE = "STSUTYPE";

        /// <summary>
        /// STHOSTTYPE.
        /// </summary>
        public const string STHOSTTYPE = "STHOSTTYPE";

        /// <summary>
        /// STSUSRCTP.
        /// </summary>
        public const string STSUSRCTP = "STSUSRCTP";

        /// <summary>
        /// STSUSTAC.
        /// </summary>
        public const string STSUSTAC = "STSUSTAC";

        /// <summary>
        /// STSUDSP.
        /// </summary>
        public const string STSUDSP = "STSUDSP";

        /// <summary>
        /// STSUF1CHAR.
        /// </summary>
        public const string STSUF1CHAR = "STSUF1CHAR";

        /// <summary>
        /// STSUF2CHAR.
        /// </summary>
        public const string STSUF2CHAR = "STSUF2CHAR";

        /// <summary>
        /// STSUF1NUM.
        /// </summary>
        public const string STSUF1NUM = "STSUF1NUM";

        /// <summary>
        /// STSUF2NUM.
        /// </summary>
        public const string STSUF2NUM = "STSUF2NUM";

        /// <summary>
        /// STSUF1STR.
        /// </summary>
        public const string STSUF1STR = "STSUF1STR";

        /// <summary>
        /// STSUF2STR.
        /// </summary>
        public const string STSUF2STR = "STSUF2STR";

        /// <summary>
        /// STSUFDATE.
        /// </summary>
        public const string STSUFDATE = "STSUFDATE";

        /// <summary>
        /// STSUFTIME.
        /// </summary>
        public const string STSUFTIME = "STSUFTIME";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STESUP", "STESUP", JdeDataType.String, 20, true, true),
        new JdeField("STSUTYPE", "STSUTYPE", JdeDataType.String, 4, true, true),
        new JdeField("STHOSTTYPE", "STHOSTTYPE", JdeDataType.String, 4, true, true),
        new JdeField("STSUSRCTP", "STSUSRCTP", JdeDataType.String, 4, true, true),
        new JdeField("STSUSTAC", "STSUSTAC", JdeDataType.String, 4),
        new JdeField("STSUDSP", "STSUDSP", JdeDataType.String, 4),
        new JdeField("STSUF1CHAR", "STSUF1CHAR", JdeDataType.String, 2),
        new JdeField("STSUF2CHAR", "STSUF2CHAR", JdeDataType.String, 2),
        new JdeField("STSUF1NUM", "STSUF1NUM", JdeDataType.Numeric),
        new JdeField("STSUF2NUM", "STSUF2NUM", JdeDataType.Numeric),
        new JdeField("STSUF1STR", "STSUF1STR", JdeDataType.String, 20),
        new JdeField("STSUF2STR", "STSUF2STR", JdeDataType.String, 60),
        new JdeField("STSUFDATE", "STSUFDATE", JdeDataType.Numeric),
        new JdeField("STSUFTIME", "STSUFTIME", JdeDataType.Numeric),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96406_0", "Primary Key on STESUP, STSUTYPE, STHOSTTYPE, STSUSRCTP", new[] { "STESUP", "STSUTYPE", "STHOSTTYPE", "STSUSRCTP" }, isUnique: true, isPrimaryKey: true)
    };
}
