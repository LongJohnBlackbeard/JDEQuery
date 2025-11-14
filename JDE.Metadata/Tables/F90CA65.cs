using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA65 - .
/// </summary>
public class F90CA65 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXCALLP.
        /// </summary>
        public const string EXCALLP = "EXCALLP";

        /// <summary>
        /// EXACTIVID.
        /// </summary>
        public const string EXACTIVID = "EXACTIVID";

        /// <summary>
        /// EXCPNAME.
        /// </summary>
        public const string EXCPNAME = "EXCPNAME";

        /// <summary>
        /// EXCPPURP.
        /// </summary>
        public const string EXCPPURP = "EXCPPURP";

        /// <summary>
        /// EXCPASK.
        /// </summary>
        public const string EXCPASK = "EXCPASK";

        /// <summary>
        /// EXCPACT.
        /// </summary>
        public const string EXCPACT = "EXCPACT";

        /// <summary>
        /// EXCPPREM.
        /// </summary>
        public const string EXCPPREM = "EXCPPREM";

        /// <summary>
        /// EXISTMP.
        /// </summary>
        public const string EXISTMP = "EXISTMP";

        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";

        /// <summary>
        /// EXUDTTM.
        /// </summary>
        public const string EXUDTTM = "EXUDTTM";

        /// <summary>
        /// EXMKEY.
        /// </summary>
        public const string EXMKEY = "EXMKEY";

        /// <summary>
        /// EXENTDBY.
        /// </summary>
        public const string EXENTDBY = "EXENTDBY";

        /// <summary>
        /// EXEDATE.
        /// </summary>
        public const string EXEDATE = "EXEDATE";

        /// <summary>
        /// EXCPDFLT.
        /// </summary>
        public const string EXCPDFLT = "EXCPDFLT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA65";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXCALLP", "EXCALLP", JdeDataType.Numeric, null, true, true),
        new JdeField("EXACTIVID", "EXACTIVID", JdeDataType.String, 72),
        new JdeField("EXCPNAME", "EXCPNAME", JdeDataType.String, 102),
        new JdeField("EXCPPURP", "EXCPPURP", JdeDataType.String, 512),
        new JdeField("EXCPASK", "EXCPASK", JdeDataType.String, 2000),
        new JdeField("EXCPACT", "EXCPACT", JdeDataType.String, 2000),
        new JdeField("EXCPPREM", "EXCPPREM", JdeDataType.String, 512),
        new JdeField("EXISTMP", "EXISTMP", JdeDataType.String, 2),
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20),
        new JdeField("EXUDTTM", "EXUDTTM", JdeDataType.Date),
        new JdeField("EXMKEY", "EXMKEY", JdeDataType.String, 30),
        new JdeField("EXENTDBY", "EXENTDBY", JdeDataType.Numeric),
        new JdeField("EXEDATE", "EXEDATE", JdeDataType.Date),
        new JdeField("EXCPDFLT", "EXCPDFLT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA65_0", "Primary Key on EXCALLP", new[] { "EXCALLP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA65_2", "Index on EXCPDFLT, EXACTIVID", new[] { "EXCPDFLT", "EXACTIVID" })
    };
}
