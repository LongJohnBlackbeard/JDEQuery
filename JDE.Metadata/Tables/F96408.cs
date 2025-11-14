using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96408 - .
/// </summary>
public class F96408 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UGSUUSER.
        /// </summary>
        public const string UGSUUSER = "UGSUUSER";

        /// <summary>
        /// UGSUGRP.
        /// </summary>
        public const string UGSUGRP = "UGSUGRP";

        /// <summary>
        /// UGSUGROW.
        /// </summary>
        public const string UGSUGROW = "UGSUGROW";

        /// <summary>
        /// UGSUSECLVL.
        /// </summary>
        public const string UGSUSECLVL = "UGSUSECLVL";

        /// <summary>
        /// UGSUGRPRT.
        /// </summary>
        public const string UGSUGRPRT = "UGSUGRPRT";

        /// <summary>
        /// UGSUF1CHAR.
        /// </summary>
        public const string UGSUF1CHAR = "UGSUF1CHAR";

        /// <summary>
        /// UGSUF2CHAR.
        /// </summary>
        public const string UGSUF2CHAR = "UGSUF2CHAR";

        /// <summary>
        /// UGSUF1NUM.
        /// </summary>
        public const string UGSUF1NUM = "UGSUF1NUM";

        /// <summary>
        /// UGSUF2NUM.
        /// </summary>
        public const string UGSUF2NUM = "UGSUF2NUM";

        /// <summary>
        /// UGSUF1STR.
        /// </summary>
        public const string UGSUF1STR = "UGSUF1STR";

        /// <summary>
        /// UGSUF2STR.
        /// </summary>
        public const string UGSUF2STR = "UGSUF2STR";

        /// <summary>
        /// UGSUFDATE.
        /// </summary>
        public const string UGSUFDATE = "UGSUFDATE";

        /// <summary>
        /// UGSUFTIME.
        /// </summary>
        public const string UGSUFTIME = "UGSUFTIME";

        /// <summary>
        /// UGJOBN.
        /// </summary>
        public const string UGJOBN = "UGJOBN";

        /// <summary>
        /// UGUSER.
        /// </summary>
        public const string UGUSER = "UGUSER";

        /// <summary>
        /// UGUPMJ.
        /// </summary>
        public const string UGUPMJ = "UGUPMJ";

        /// <summary>
        /// UGUPMT.
        /// </summary>
        public const string UGUPMT = "UGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96408";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UGSUUSER", "UGSUUSER", JdeDataType.String, 40, true, true),
        new JdeField("UGSUGRP", "UGSUGRP", JdeDataType.String, 80, true, true),
        new JdeField("UGSUGROW", "UGSUGROW", JdeDataType.String, 20),
        new JdeField("UGSUSECLVL", "UGSUSECLVL", JdeDataType.String, 4),
        new JdeField("UGSUGRPRT", "UGSUGRPRT", JdeDataType.String, 4),
        new JdeField("UGSUF1CHAR", "UGSUF1CHAR", JdeDataType.String, 2),
        new JdeField("UGSUF2CHAR", "UGSUF2CHAR", JdeDataType.String, 2),
        new JdeField("UGSUF1NUM", "UGSUF1NUM", JdeDataType.Numeric),
        new JdeField("UGSUF2NUM", "UGSUF2NUM", JdeDataType.Numeric),
        new JdeField("UGSUF1STR", "UGSUF1STR", JdeDataType.String, 20),
        new JdeField("UGSUF2STR", "UGSUF2STR", JdeDataType.String, 60),
        new JdeField("UGSUFDATE", "UGSUFDATE", JdeDataType.Numeric),
        new JdeField("UGSUFTIME", "UGSUFTIME", JdeDataType.Numeric),
        new JdeField("UGJOBN", "UGJOBN", JdeDataType.String, 20),
        new JdeField("UGUSER", "UGUSER", JdeDataType.String, 20),
        new JdeField("UGUPMJ", "UGUPMJ", JdeDataType.Numeric),
        new JdeField("UGUPMT", "UGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96408_0", "Primary Key on UGSUUSER, UGSUGRP", new[] { "UGSUUSER", "UGSUGRP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F96408_2", "Index on UGSUGRP", new[] { "UGSUGRP" }),
        new JdeIndex("F96408_4", "Index on UGSUUSER", new[] { "UGSUUSER" })
    };
}
