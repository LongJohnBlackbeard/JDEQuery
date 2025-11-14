using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96407 - .
/// </summary>
public class F96407 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDESUP.
        /// </summary>
        public const string SDESUP = "SDESUP";

        /// <summary>
        /// SDSUTYPE.
        /// </summary>
        public const string SDSUTYPE = "SDSUTYPE";

        /// <summary>
        /// SDHOSTTYPE.
        /// </summary>
        public const string SDHOSTTYPE = "SDHOSTTYPE";

        /// <summary>
        /// SDSUSTATAC.
        /// </summary>
        public const string SDSUSTATAC = "SDSUSTATAC";

        /// <summary>
        /// SDSUDSP.
        /// </summary>
        public const string SDSUDSP = "SDSUDSP";

        /// <summary>
        /// SDSUF1CHAR.
        /// </summary>
        public const string SDSUF1CHAR = "SDSUF1CHAR";

        /// <summary>
        /// SDSUF2CHAR.
        /// </summary>
        public const string SDSUF2CHAR = "SDSUF2CHAR";

        /// <summary>
        /// SDSUF1NUM.
        /// </summary>
        public const string SDSUF1NUM = "SDSUF1NUM";

        /// <summary>
        /// SDSUF2NUM.
        /// </summary>
        public const string SDSUF2NUM = "SDSUF2NUM";

        /// <summary>
        /// SDSUF1STR.
        /// </summary>
        public const string SDSUF1STR = "SDSUF1STR";

        /// <summary>
        /// SDSUF2STR.
        /// </summary>
        public const string SDSUF2STR = "SDSUF2STR";

        /// <summary>
        /// SDSUFDATE.
        /// </summary>
        public const string SDSUFDATE = "SDSUFDATE";

        /// <summary>
        /// SDSUFTIME.
        /// </summary>
        public const string SDSUFTIME = "SDSUFTIME";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96407";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDESUP", "SDESUP", JdeDataType.String, 20, true, true),
        new JdeField("SDSUTYPE", "SDSUTYPE", JdeDataType.String, 4, true, true),
        new JdeField("SDHOSTTYPE", "SDHOSTTYPE", JdeDataType.String, 4, true, true),
        new JdeField("SDSUSTATAC", "SDSUSTATAC", JdeDataType.String, 4),
        new JdeField("SDSUDSP", "SDSUDSP", JdeDataType.String, 4),
        new JdeField("SDSUF1CHAR", "SDSUF1CHAR", JdeDataType.String, 2),
        new JdeField("SDSUF2CHAR", "SDSUF2CHAR", JdeDataType.String, 2),
        new JdeField("SDSUF1NUM", "SDSUF1NUM", JdeDataType.Numeric),
        new JdeField("SDSUF2NUM", "SDSUF2NUM", JdeDataType.Numeric),
        new JdeField("SDSUF1STR", "SDSUF1STR", JdeDataType.String, 20),
        new JdeField("SDSUF2STR", "SDSUF2STR", JdeDataType.String, 60),
        new JdeField("SDSUFDATE", "SDSUFDATE", JdeDataType.Numeric),
        new JdeField("SDSUFTIME", "SDSUFTIME", JdeDataType.Numeric),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96407_0", "Primary Key on SDESUP, SDHOSTTYPE, SDSUTYPE", new[] { "SDESUP", "SDHOSTTYPE", "SDSUTYPE" }, isUnique: true, isPrimaryKey: true)
    };
}
