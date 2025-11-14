using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40741 - .
/// </summary>
public class F40741 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHDCTO.
        /// </summary>
        public const string PHDCTO = "PHDCTO";

        /// <summary>
        /// PHKCOO.
        /// </summary>
        public const string PHKCOO = "PHKCOO";

        /// <summary>
        /// PHLNID.
        /// </summary>
        public const string PHLNID = "PHLNID";

        /// <summary>
        /// PHSFXO.
        /// </summary>
        public const string PHSFXO = "PHSFXO";

        /// <summary>
        /// PHOSEQ.
        /// </summary>
        public const string PHOSEQ = "PHOSEQ";

        /// <summary>
        /// PHSEQ.
        /// </summary>
        public const string PHSEQ = "PHSEQ";

        /// <summary>
        /// PHDTAI.
        /// </summary>
        public const string PHDTAI = "PHDTAI";

        /// <summary>
        /// PHGENMATH.
        /// </summary>
        public const string PHGENMATH = "PHGENMATH";

        /// <summary>
        /// PHGENSTR.
        /// </summary>
        public const string PHGENSTR = "PHGENSTR";

        /// <summary>
        /// PHGENCHAR.
        /// </summary>
        public const string PHGENCHAR = "PHGENCHAR";

        /// <summary>
        /// PHGENDATE.
        /// </summary>
        public const string PHGENDATE = "PHGENDATE";

        /// <summary>
        /// PHAPTYPE.
        /// </summary>
        public const string PHAPTYPE = "PHAPTYPE";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHTDAY.
        /// </summary>
        public const string PHTDAY = "PHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40741";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDCTO", "PHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PHKCOO", "PHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PHLNID", "PHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PHSFXO", "PHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PHOSEQ", "PHOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PHSEQ", "PHSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDTAI", "PHDTAI", JdeDataType.String, 20, true, true),
        new JdeField("PHGENMATH", "PHGENMATH", JdeDataType.Numeric),
        new JdeField("PHGENSTR", "PHGENSTR", JdeDataType.String, 60),
        new JdeField("PHGENCHAR", "PHGENCHAR", JdeDataType.String, 2),
        new JdeField("PHGENDATE", "PHGENDATE", JdeDataType.Numeric),
        new JdeField("PHAPTYPE", "PHAPTYPE", JdeDataType.String, 4),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHTDAY", "PHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40741_0", "Primary Key on PHDOCO, PHDCTO, PHKCOO, PHLNID, PHSFXO, PHOSEQ, PHSEQ, PHDTAI", new[] { "PHDOCO", "PHDCTO", "PHKCOO", "PHLNID", "PHSFXO", "PHOSEQ", "PHSEQ", "PHDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
