using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4956 - .
/// </summary>
public class F4956 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IXMOT.
        /// </summary>
        public const string IXMOT = "IXMOT";

        /// <summary>
        /// IXCARS.
        /// </summary>
        public const string IXCARS = "IXCARS";

        /// <summary>
        /// IXRTN.
        /// </summary>
        public const string IXRTN = "IXRTN";

        /// <summary>
        /// IXOPEQ.
        /// </summary>
        public const string IXOPEQ = "IXOPEQ";

        /// <summary>
        /// IXEFTJ.
        /// </summary>
        public const string IXEFTJ = "IXEFTJ";

        /// <summary>
        /// IXEXDJ.
        /// </summary>
        public const string IXEXDJ = "IXEXDJ";

        /// <summary>
        /// IXILEL.
        /// </summary>
        public const string IXILEL = "IXILEL";

        /// <summary>
        /// IXNMCU.
        /// </summary>
        public const string IXNMCU = "IXNMCU";

        /// <summary>
        /// IXURCD.
        /// </summary>
        public const string IXURCD = "IXURCD";

        /// <summary>
        /// IXURDT.
        /// </summary>
        public const string IXURDT = "IXURDT";

        /// <summary>
        /// IXURAT.
        /// </summary>
        public const string IXURAT = "IXURAT";

        /// <summary>
        /// IXURAB.
        /// </summary>
        public const string IXURAB = "IXURAB";

        /// <summary>
        /// IXURRF.
        /// </summary>
        public const string IXURRF = "IXURRF";

        /// <summary>
        /// IXUSER.
        /// </summary>
        public const string IXUSER = "IXUSER";

        /// <summary>
        /// IXPID.
        /// </summary>
        public const string IXPID = "IXPID";

        /// <summary>
        /// IXJOBN.
        /// </summary>
        public const string IXJOBN = "IXJOBN";

        /// <summary>
        /// IXUPMJ.
        /// </summary>
        public const string IXUPMJ = "IXUPMJ";

        /// <summary>
        /// IXTDAY.
        /// </summary>
        public const string IXTDAY = "IXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4956";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IXMOT", "IXMOT", JdeDataType.String, 6, true, true),
        new JdeField("IXCARS", "IXCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("IXRTN", "IXRTN", JdeDataType.Numeric, null, true, true),
        new JdeField("IXOPEQ", "IXOPEQ", JdeDataType.String, 20, true, true),
        new JdeField("IXEFTJ", "IXEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IXEXDJ", "IXEXDJ", JdeDataType.Numeric),
        new JdeField("IXILEL", "IXILEL", JdeDataType.String, 2),
        new JdeField("IXNMCU", "IXNMCU", JdeDataType.String, 24),
        new JdeField("IXURCD", "IXURCD", JdeDataType.String, 4),
        new JdeField("IXURDT", "IXURDT", JdeDataType.Numeric),
        new JdeField("IXURAT", "IXURAT", JdeDataType.Numeric),
        new JdeField("IXURAB", "IXURAB", JdeDataType.Numeric),
        new JdeField("IXURRF", "IXURRF", JdeDataType.String, 30),
        new JdeField("IXUSER", "IXUSER", JdeDataType.String, 20),
        new JdeField("IXPID", "IXPID", JdeDataType.String, 20),
        new JdeField("IXJOBN", "IXJOBN", JdeDataType.String, 20),
        new JdeField("IXUPMJ", "IXUPMJ", JdeDataType.Numeric),
        new JdeField("IXTDAY", "IXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4956_0", "Primary Key on IXMOT, IXCARS, IXRTN, IXOPEQ, IXEFTJ", new[] { "IXMOT", "IXCARS", "IXRTN", "IXOPEQ", "IXEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
