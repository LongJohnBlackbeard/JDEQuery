using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0046 - .
/// </summary>
public class F0046 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLEDUS.
        /// </summary>
        public const string PLEDUS = "PLEDUS";

        /// <summary>
        /// PLEDBT.
        /// </summary>
        public const string PLEDBT = "PLEDBT";

        /// <summary>
        /// PLEDTN.
        /// </summary>
        public const string PLEDTN = "PLEDTN";

        /// <summary>
        /// PLEDLN.
        /// </summary>
        public const string PLEDLN = "PLEDLN";

        /// <summary>
        /// PLTYTN.
        /// </summary>
        public const string PLTYTN = "PLTYTN";

        /// <summary>
        /// PLDCTO.
        /// </summary>
        public const string PLDCTO = "PLDCTO";

        /// <summary>
        /// PLSEQ.
        /// </summary>
        public const string PLSEQ = "PLSEQ";

        /// <summary>
        /// PLOBNM.
        /// </summary>
        public const string PLOBNM = "PLOBNM";

        /// <summary>
        /// PLVERS.
        /// </summary>
        public const string PLVERS = "PLVERS";

        /// <summary>
        /// PLEDSP.
        /// </summary>
        public const string PLEDSP = "PLEDSP";
    }

    /// <inheritdoc />
    public override string TableName => "F0046";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLEDUS", "PLEDUS", JdeDataType.String, 20, true, true),
        new JdeField("PLEDBT", "PLEDBT", JdeDataType.String, 30, true, true),
        new JdeField("PLEDTN", "PLEDTN", JdeDataType.String, 44, true, true),
        new JdeField("PLEDLN", "PLEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PLTYTN", "PLTYTN", JdeDataType.String, 16, true, true),
        new JdeField("PLDCTO", "PLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PLSEQ", "PLSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PLOBNM", "PLOBNM", JdeDataType.String, 20),
        new JdeField("PLVERS", "PLVERS", JdeDataType.String, 20),
        new JdeField("PLEDSP", "PLEDSP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0046_0", "Primary Key on PLEDUS, PLEDBT, PLEDTN, PLEDLN, PLTYTN, PLDCTO, PLSEQ", new[] { "PLEDUS", "PLEDBT", "PLEDTN", "PLEDLN", "PLTYTN", "PLDCTO", "PLSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0046_2", "Index on PLOBNM, PLVERS, PLEDSP", new[] { "PLOBNM", "PLVERS", "PLEDSP" })
    };
}
