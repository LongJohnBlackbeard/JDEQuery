using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0047 - .
/// </summary>
public class F0047 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DETYTN.
        /// </summary>
        public const string DETYTN = "DETYTN";

        /// <summary>
        /// DEDCTO.
        /// </summary>
        public const string DEDCTO = "DEDCTO";

        /// <summary>
        /// DESEQ.
        /// </summary>
        public const string DESEQ = "DESEQ";

        /// <summary>
        /// DEOBNM.
        /// </summary>
        public const string DEOBNM = "DEOBNM";

        /// <summary>
        /// DEVERS.
        /// </summary>
        public const string DEVERS = "DEVERS";

        /// <summary>
        /// DEFCNN.
        /// </summary>
        public const string DEFCNN = "DEFCNN";

        /// <summary>
        /// DEFCNL.
        /// </summary>
        public const string DEFCNL = "DEFCNL";

        /// <summary>
        /// DEEXEA.
        /// </summary>
        public const string DEEXEA = "DEEXEA";

        /// <summary>
        /// DEEXEU.
        /// </summary>
        public const string DEEXEU = "DEEXEU";

        /// <summary>
        /// DEEXED.
        /// </summary>
        public const string DEEXED = "DEEXED";

        /// <summary>
        /// DEEXEI.
        /// </summary>
        public const string DEEXEI = "DEEXEI";

        /// <summary>
        /// DEFFEM.
        /// </summary>
        public const string DEFFEM = "DEFFEM";

        /// <summary>
        /// DEEDEM.
        /// </summary>
        public const string DEEDEM = "DEEDEM";

        /// <summary>
        /// DEEAEM.
        /// </summary>
        public const string DEEAEM = "DEEAEM";

        /// <summary>
        /// DELCIM.
        /// </summary>
        public const string DELCIM = "DELCIM";
    }

    /// <inheritdoc />
    public override string TableName => "F0047";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DETYTN", "DETYTN", JdeDataType.String, 16, true, true),
        new JdeField("DEDCTO", "DEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DESEQ", "DESEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DEOBNM", "DEOBNM", JdeDataType.String, 20),
        new JdeField("DEVERS", "DEVERS", JdeDataType.String, 20),
        new JdeField("DEFCNN", "DEFCNN", JdeDataType.String, 100),
        new JdeField("DEFCNL", "DEFCNL", JdeDataType.String, 512),
        new JdeField("DEEXEA", "DEEXEA", JdeDataType.String, 2),
        new JdeField("DEEXEU", "DEEXEU", JdeDataType.String, 2),
        new JdeField("DEEXED", "DEEXED", JdeDataType.String, 2),
        new JdeField("DEEXEI", "DEEXEI", JdeDataType.String, 2),
        new JdeField("DEFFEM", "DEFFEM", JdeDataType.String, 2),
        new JdeField("DEEDEM", "DEEDEM", JdeDataType.String, 2),
        new JdeField("DEEAEM", "DEEAEM", JdeDataType.String, 2),
        new JdeField("DELCIM", "DELCIM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0047_0", "Primary Key on DETYTN, DEDCTO, DESEQ", new[] { "DETYTN", "DEDCTO", "DESEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0047_2", "Index on DETYTN, DEDCTO, DEOBNM, DEVERS", new[] { "DETYTN", "DEDCTO", "DEOBNM", "DEVERS" })
    };
}
