using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32921 - .
/// </summary>
public class F32921 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KXFCOD.
        /// </summary>
        public const string KXFCOD = "KXFCOD";

        /// <summary>
        /// KXKIT.
        /// </summary>
        public const string KXKIT = "KXKIT";

        /// <summary>
        /// KXMCU.
        /// </summary>
        public const string KXMCU = "KXMCU";

        /// <summary>
        /// KXATO#.
        /// </summary>
        public const string KXATO_ = "KXATO#";

        /// <summary>
        /// KXATOS.
        /// </summary>
        public const string KXATOS = "KXATOS";

        /// <summary>
        /// KXSGVL.
        /// </summary>
        public const string KXSGVL = "KXSGVL";

        /// <summary>
        /// KXEFFF.
        /// </summary>
        public const string KXEFFF = "KXEFFF";

        /// <summary>
        /// KXEFFT.
        /// </summary>
        public const string KXEFFT = "KXEFFT";

        /// <summary>
        /// KXURCD.
        /// </summary>
        public const string KXURCD = "KXURCD";

        /// <summary>
        /// KXURDT.
        /// </summary>
        public const string KXURDT = "KXURDT";

        /// <summary>
        /// KXURAT.
        /// </summary>
        public const string KXURAT = "KXURAT";

        /// <summary>
        /// KXURAB.
        /// </summary>
        public const string KXURAB = "KXURAB";

        /// <summary>
        /// KXURRF.
        /// </summary>
        public const string KXURRF = "KXURRF";

        /// <summary>
        /// KXUSER.
        /// </summary>
        public const string KXUSER = "KXUSER";

        /// <summary>
        /// KXPID.
        /// </summary>
        public const string KXPID = "KXPID";

        /// <summary>
        /// KXJOBN.
        /// </summary>
        public const string KXJOBN = "KXJOBN";

        /// <summary>
        /// KXUPMJ.
        /// </summary>
        public const string KXUPMJ = "KXUPMJ";

        /// <summary>
        /// KXTDAY.
        /// </summary>
        public const string KXTDAY = "KXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32921";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KXFCOD", "KXFCOD", JdeDataType.String, 2, true, true),
        new JdeField("KXKIT", "KXKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KXMCU", "KXMCU", JdeDataType.String, 24, true, true),
        new JdeField("KXATO#", "KXATO#", JdeDataType.Numeric, null, true, true),
        new JdeField("KXATOS", "KXATOS", JdeDataType.Numeric, null, true, true),
        new JdeField("KXSGVL", "KXSGVL", JdeDataType.String, 80, true, true),
        new JdeField("KXEFFF", "KXEFFF", JdeDataType.Numeric),
        new JdeField("KXEFFT", "KXEFFT", JdeDataType.Numeric),
        new JdeField("KXURCD", "KXURCD", JdeDataType.String, 4),
        new JdeField("KXURDT", "KXURDT", JdeDataType.Numeric),
        new JdeField("KXURAT", "KXURAT", JdeDataType.Numeric),
        new JdeField("KXURAB", "KXURAB", JdeDataType.Numeric),
        new JdeField("KXURRF", "KXURRF", JdeDataType.String, 30),
        new JdeField("KXUSER", "KXUSER", JdeDataType.String, 20),
        new JdeField("KXPID", "KXPID", JdeDataType.String, 20),
        new JdeField("KXJOBN", "KXJOBN", JdeDataType.String, 20),
        new JdeField("KXUPMJ", "KXUPMJ", JdeDataType.Numeric),
        new JdeField("KXTDAY", "KXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32921_0", "Primary Key on KXFCOD, KXKIT, KXMCU, KXATO#, KXATOS, KXSGVL", new[] { "KXFCOD", "KXKIT", "KXMCU", "KXATO#", "KXATOS", "KXSGVL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F32921_2", "Index on KXKIT, KXMCU, KXATO#, KXATOS, KXSGVL", new[] { "KXKIT", "KXMCU", "KXATO#", "KXATOS", "KXSGVL" })
    };
}
