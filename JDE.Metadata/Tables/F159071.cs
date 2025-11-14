using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F159071 - .
/// </summary>
public class F159071 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NYCO.
        /// </summary>
        public const string NYCO = "NYCO";

        /// <summary>
        /// NYMCU.
        /// </summary>
        public const string NYMCU = "NYMCU";

        /// <summary>
        /// NYFLOR.
        /// </summary>
        public const string NYFLOR = "NYFLOR";

        /// <summary>
        /// NYUNIT.
        /// </summary>
        public const string NYUNIT = "NYUNIT";

        /// <summary>
        /// NYRNTY.
        /// </summary>
        public const string NYRNTY = "NYRNTY";

        /// <summary>
        /// NYSEQ.
        /// </summary>
        public const string NYSEQ = "NYSEQ";

        /// <summary>
        /// NYRENA.
        /// </summary>
        public const string NYRENA = "NYRENA";

        /// <summary>
        /// NYEFTB.
        /// </summary>
        public const string NYEFTB = "NYEFTB";

        /// <summary>
        /// NYEFTE.
        /// </summary>
        public const string NYEFTE = "NYEFTE";

        /// <summary>
        /// NYDL01.
        /// </summary>
        public const string NYDL01 = "NYDL01";

        /// <summary>
        /// NYURCD.
        /// </summary>
        public const string NYURCD = "NYURCD";

        /// <summary>
        /// NYURDT.
        /// </summary>
        public const string NYURDT = "NYURDT";

        /// <summary>
        /// NYURAT.
        /// </summary>
        public const string NYURAT = "NYURAT";

        /// <summary>
        /// NYURAB.
        /// </summary>
        public const string NYURAB = "NYURAB";

        /// <summary>
        /// NYURRF.
        /// </summary>
        public const string NYURRF = "NYURRF";

        /// <summary>
        /// NYUSER.
        /// </summary>
        public const string NYUSER = "NYUSER";

        /// <summary>
        /// NYPID.
        /// </summary>
        public const string NYPID = "NYPID";

        /// <summary>
        /// NYUPMJ.
        /// </summary>
        public const string NYUPMJ = "NYUPMJ";

        /// <summary>
        /// NYUPMT.
        /// </summary>
        public const string NYUPMT = "NYUPMT";

        /// <summary>
        /// NYJOBN.
        /// </summary>
        public const string NYJOBN = "NYJOBN";

        /// <summary>
        /// NYENTJ.
        /// </summary>
        public const string NYENTJ = "NYENTJ";

        /// <summary>
        /// NYTORG.
        /// </summary>
        public const string NYTORG = "NYTORG";

        /// <summary>
        /// NYCRCD.
        /// </summary>
        public const string NYCRCD = "NYCRCD";

        /// <summary>
        /// NYCRRM.
        /// </summary>
        public const string NYCRRM = "NYCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F159071";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NYCO", "NYCO", JdeDataType.String, 10),
        new JdeField("NYMCU", "NYMCU", JdeDataType.String, 24, true, true),
        new JdeField("NYFLOR", "NYFLOR", JdeDataType.String, 8),
        new JdeField("NYUNIT", "NYUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NYRNTY", "NYRNTY", JdeDataType.String, 2, true, true),
        new JdeField("NYSEQ", "NYSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("NYRENA", "NYRENA", JdeDataType.Numeric),
        new JdeField("NYEFTB", "NYEFTB", JdeDataType.Numeric),
        new JdeField("NYEFTE", "NYEFTE", JdeDataType.Numeric),
        new JdeField("NYDL01", "NYDL01", JdeDataType.String, 60),
        new JdeField("NYURCD", "NYURCD", JdeDataType.String, 4),
        new JdeField("NYURDT", "NYURDT", JdeDataType.Numeric),
        new JdeField("NYURAT", "NYURAT", JdeDataType.Numeric),
        new JdeField("NYURAB", "NYURAB", JdeDataType.Numeric),
        new JdeField("NYURRF", "NYURRF", JdeDataType.String, 30),
        new JdeField("NYUSER", "NYUSER", JdeDataType.String, 20),
        new JdeField("NYPID", "NYPID", JdeDataType.String, 20),
        new JdeField("NYUPMJ", "NYUPMJ", JdeDataType.Numeric),
        new JdeField("NYUPMT", "NYUPMT", JdeDataType.Numeric),
        new JdeField("NYJOBN", "NYJOBN", JdeDataType.String, 20),
        new JdeField("NYENTJ", "NYENTJ", JdeDataType.Numeric),
        new JdeField("NYTORG", "NYTORG", JdeDataType.String, 20),
        new JdeField("NYCRCD", "NYCRCD", JdeDataType.String, 6),
        new JdeField("NYCRRM", "NYCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F159071_0", "Primary Key on NYMCU, NYUNIT, NYRNTY, NYSEQ", new[] { "NYMCU", "NYUNIT", "NYRNTY", "NYSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F159071_2", "Index on NYMCU, NYUNIT, NYRNTY, SYS_NC00025$", new[] { "NYMCU", "NYUNIT", "NYRNTY", "SYS_NC00025$" })
    };
}
