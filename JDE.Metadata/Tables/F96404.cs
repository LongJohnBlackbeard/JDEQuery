using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96404 - .
/// </summary>
public class F96404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// URESUP.
        /// </summary>
        public const string URESUP = "URESUP";

        /// <summary>
        /// URSUTYPE.
        /// </summary>
        public const string URSUTYPE = "URSUTYPE";

        /// <summary>
        /// URHOSTTYPE.
        /// </summary>
        public const string URHOSTTYPE = "URHOSTTYPE";

        /// <summary>
        /// URSUUSER.
        /// </summary>
        public const string URSUUSER = "URSUUSER";

        /// <summary>
        /// URSUUSAC.
        /// </summary>
        public const string URSUUSAC = "URSUUSAC";

        /// <summary>
        /// URSUDSP.
        /// </summary>
        public const string URSUDSP = "URSUDSP";

        /// <summary>
        /// URSUF1CHAR.
        /// </summary>
        public const string URSUF1CHAR = "URSUF1CHAR";

        /// <summary>
        /// URSUF2CHAR.
        /// </summary>
        public const string URSUF2CHAR = "URSUF2CHAR";

        /// <summary>
        /// URSUF1NUM.
        /// </summary>
        public const string URSUF1NUM = "URSUF1NUM";

        /// <summary>
        /// URSUF2NUM.
        /// </summary>
        public const string URSUF2NUM = "URSUF2NUM";

        /// <summary>
        /// URSUF1STR.
        /// </summary>
        public const string URSUF1STR = "URSUF1STR";

        /// <summary>
        /// URSUF2STR.
        /// </summary>
        public const string URSUF2STR = "URSUF2STR";

        /// <summary>
        /// URSUFDATE.
        /// </summary>
        public const string URSUFDATE = "URSUFDATE";

        /// <summary>
        /// URSUFTIME.
        /// </summary>
        public const string URSUFTIME = "URSUFTIME";

        /// <summary>
        /// URUSER.
        /// </summary>
        public const string URUSER = "URUSER";

        /// <summary>
        /// URJOBN.
        /// </summary>
        public const string URJOBN = "URJOBN";

        /// <summary>
        /// URUPMJ.
        /// </summary>
        public const string URUPMJ = "URUPMJ";

        /// <summary>
        /// URUPMT.
        /// </summary>
        public const string URUPMT = "URUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("URESUP", "URESUP", JdeDataType.String, 20, true, true),
        new JdeField("URSUTYPE", "URSUTYPE", JdeDataType.String, 4, true, true),
        new JdeField("URHOSTTYPE", "URHOSTTYPE", JdeDataType.String, 4, true, true),
        new JdeField("URSUUSER", "URSUUSER", JdeDataType.String, 40, true, true),
        new JdeField("URSUUSAC", "URSUUSAC", JdeDataType.String, 4),
        new JdeField("URSUDSP", "URSUDSP", JdeDataType.String, 4),
        new JdeField("URSUF1CHAR", "URSUF1CHAR", JdeDataType.String, 2),
        new JdeField("URSUF2CHAR", "URSUF2CHAR", JdeDataType.String, 2),
        new JdeField("URSUF1NUM", "URSUF1NUM", JdeDataType.Numeric),
        new JdeField("URSUF2NUM", "URSUF2NUM", JdeDataType.Numeric),
        new JdeField("URSUF1STR", "URSUF1STR", JdeDataType.String, 20),
        new JdeField("URSUF2STR", "URSUF2STR", JdeDataType.String, 60),
        new JdeField("URSUFDATE", "URSUFDATE", JdeDataType.Numeric),
        new JdeField("URSUFTIME", "URSUFTIME", JdeDataType.Numeric),
        new JdeField("URUSER", "URUSER", JdeDataType.String, 20),
        new JdeField("URJOBN", "URJOBN", JdeDataType.String, 20),
        new JdeField("URUPMJ", "URUPMJ", JdeDataType.Numeric),
        new JdeField("URUPMT", "URUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96404_0", "Primary Key on URESUP, URSUTYPE, URHOSTTYPE, URSUUSER", new[] { "URESUP", "URSUTYPE", "URHOSTTYPE", "URSUUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
