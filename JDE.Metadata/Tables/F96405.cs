using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96405 - .
/// </summary>
public class F96405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRESUP.
        /// </summary>
        public const string GRESUP = "GRESUP";

        /// <summary>
        /// GRSUTYPE.
        /// </summary>
        public const string GRSUTYPE = "GRSUTYPE";

        /// <summary>
        /// GRHOSTTYPE.
        /// </summary>
        public const string GRHOSTTYPE = "GRHOSTTYPE";

        /// <summary>
        /// GRSUGRP.
        /// </summary>
        public const string GRSUGRP = "GRSUGRP";

        /// <summary>
        /// GRSUGRAC.
        /// </summary>
        public const string GRSUGRAC = "GRSUGRAC";

        /// <summary>
        /// GRSUDSP.
        /// </summary>
        public const string GRSUDSP = "GRSUDSP";

        /// <summary>
        /// GRSUF1CHAR.
        /// </summary>
        public const string GRSUF1CHAR = "GRSUF1CHAR";

        /// <summary>
        /// GRSUF2CHAR.
        /// </summary>
        public const string GRSUF2CHAR = "GRSUF2CHAR";

        /// <summary>
        /// GRSUF1NUM.
        /// </summary>
        public const string GRSUF1NUM = "GRSUF1NUM";

        /// <summary>
        /// GRSUF2NUM.
        /// </summary>
        public const string GRSUF2NUM = "GRSUF2NUM";

        /// <summary>
        /// GRSUF1STR.
        /// </summary>
        public const string GRSUF1STR = "GRSUF1STR";

        /// <summary>
        /// GRSUF2STR.
        /// </summary>
        public const string GRSUF2STR = "GRSUF2STR";

        /// <summary>
        /// GRSUFDATE.
        /// </summary>
        public const string GRSUFDATE = "GRSUFDATE";

        /// <summary>
        /// GRSUFTIME.
        /// </summary>
        public const string GRSUFTIME = "GRSUFTIME";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRESUP", "GRESUP", JdeDataType.String, 20, true, true),
        new JdeField("GRSUTYPE", "GRSUTYPE", JdeDataType.String, 4, true, true),
        new JdeField("GRHOSTTYPE", "GRHOSTTYPE", JdeDataType.String, 4, true, true),
        new JdeField("GRSUGRP", "GRSUGRP", JdeDataType.String, 80, true, true),
        new JdeField("GRSUGRAC", "GRSUGRAC", JdeDataType.String, 4),
        new JdeField("GRSUDSP", "GRSUDSP", JdeDataType.String, 4),
        new JdeField("GRSUF1CHAR", "GRSUF1CHAR", JdeDataType.String, 2),
        new JdeField("GRSUF2CHAR", "GRSUF2CHAR", JdeDataType.String, 2),
        new JdeField("GRSUF1NUM", "GRSUF1NUM", JdeDataType.Numeric),
        new JdeField("GRSUF2NUM", "GRSUF2NUM", JdeDataType.Numeric),
        new JdeField("GRSUF1STR", "GRSUF1STR", JdeDataType.String, 20),
        new JdeField("GRSUF2STR", "GRSUF2STR", JdeDataType.String, 60),
        new JdeField("GRSUFDATE", "GRSUFDATE", JdeDataType.Numeric),
        new JdeField("GRSUFTIME", "GRSUFTIME", JdeDataType.Numeric),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96405_0", "Primary Key on GRESUP, GRSUTYPE, GRHOSTTYPE, GRSUGRP", new[] { "GRESUP", "GRSUTYPE", "GRHOSTTYPE", "GRSUGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
