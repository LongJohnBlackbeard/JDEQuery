using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F097021W - .
/// </summary>
public class F097021W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAUKID.
        /// </summary>
        public const string TAUKID = "TAUKID";

        /// <summary>
        /// TADCT.
        /// </summary>
        public const string TADCT = "TADCT";

        /// <summary>
        /// TADOC.
        /// </summary>
        public const string TADOC = "TADOC";

        /// <summary>
        /// TAKCO.
        /// </summary>
        public const string TAKCO = "TAKCO";

        /// <summary>
        /// TADGJ.
        /// </summary>
        public const string TADGJ = "TADGJ";

        /// <summary>
        /// TAJELN.
        /// </summary>
        public const string TAJELN = "TAJELN";

        /// <summary>
        /// TAEXTL.
        /// </summary>
        public const string TAEXTL = "TAEXTL";

        /// <summary>
        /// TAICU.
        /// </summary>
        public const string TAICU = "TAICU";

        /// <summary>
        /// TAICUT.
        /// </summary>
        public const string TAICUT = "TAICUT";

        /// <summary>
        /// TAALCO.
        /// </summary>
        public const string TAALCO = "TAALCO";

        /// <summary>
        /// TAAMCO.
        /// </summary>
        public const string TAAMCO = "TAAMCO";

        /// <summary>
        /// TAEXA.
        /// </summary>
        public const string TAEXA = "TAEXA";

        /// <summary>
        /// TAEXR.
        /// </summary>
        public const string TAEXR = "TAEXR";

        /// <summary>
        /// TAANI.
        /// </summary>
        public const string TAANI = "TAANI";

        /// <summary>
        /// TAAA.
        /// </summary>
        public const string TAAA = "TAAA";

        /// <summary>
        /// TALT.
        /// </summary>
        public const string TALT = "TALT";

        /// <summary>
        /// TAPOST.
        /// </summary>
        public const string TAPOST = "TAPOST";

        /// <summary>
        /// TACRCD.
        /// </summary>
        public const string TACRCD = "TACRCD";

        /// <summary>
        /// TAAID.
        /// </summary>
        public const string TAAID = "TAAID";
    }

    /// <inheritdoc />
    public override string TableName => "F097021W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20, true, true),
        new JdeField("TAUKID", "TAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TADCT", "TADCT", JdeDataType.String, 4, true, true),
        new JdeField("TADOC", "TADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TAKCO", "TAKCO", JdeDataType.String, 10, true, true),
        new JdeField("TADGJ", "TADGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TAJELN", "TAJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("TAEXTL", "TAEXTL", JdeDataType.String, 4, true, true),
        new JdeField("TAICU", "TAICU", JdeDataType.Numeric),
        new JdeField("TAICUT", "TAICUT", JdeDataType.String, 4),
        new JdeField("TAALCO", "TAALCO", JdeDataType.String, 10),
        new JdeField("TAAMCO", "TAAMCO", JdeDataType.String, 10),
        new JdeField("TAEXA", "TAEXA", JdeDataType.String, 60),
        new JdeField("TAEXR", "TAEXR", JdeDataType.String, 60),
        new JdeField("TAANI", "TAANI", JdeDataType.String, 58),
        new JdeField("TAAA", "TAAA", JdeDataType.Numeric),
        new JdeField("TALT", "TALT", JdeDataType.String, 4, true, true),
        new JdeField("TAPOST", "TAPOST", JdeDataType.String, 2),
        new JdeField("TACRCD", "TACRCD", JdeDataType.String, 6),
        new JdeField("TAAID", "TAAID", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F097021W_0", "Primary Key on TAUSER, TAUKID, TADCT, TADOC, TAKCO, TADGJ, TAJELN, TALT, TAEXTL", new[] { "TAUSER", "TAUKID", "TADCT", "TADOC", "TAKCO", "TADGJ", "TAJELN", "TALT", "TAEXTL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F097021W_2", "Index on TAUSER, TAUKID, TAAID, TALT, TADGJ", new[] { "TAUSER", "TAUKID", "TAAID", "TALT", "TADGJ" })
    };
}
