using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4452 - .
/// </summary>
public class F4452 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAELEV.
        /// </summary>
        public const string JAELEV = "JAELEV";

        /// <summary>
        /// JAPL.
        /// </summary>
        public const string JAPL = "JAPL";

        /// <summary>
        /// JADL01.
        /// </summary>
        public const string JADL01 = "JADL01";

        /// <summary>
        /// JASQFT.
        /// </summary>
        public const string JASQFT = "JASQFT";

        /// <summary>
        /// JASTRY.
        /// </summary>
        public const string JASTRY = "JASTRY";

        /// <summary>
        /// JABEDR.
        /// </summary>
        public const string JABEDR = "JABEDR";

        /// <summary>
        /// JABTH.
        /// </summary>
        public const string JABTH = "JABTH";

        /// <summary>
        /// JAAPLP.
        /// </summary>
        public const string JAAPLP = "JAAPLP";

        /// <summary>
        /// JAAYR.
        /// </summary>
        public const string JAAYR = "JAAYR";

        /// <summary>
        /// JAMCUS.
        /// </summary>
        public const string JAMCUS = "JAMCUS";

        /// <summary>
        /// JASPJ.
        /// </summary>
        public const string JASPJ = "JASPJ";

        /// <summary>
        /// JABSP.
        /// </summary>
        public const string JABSP = "JABSP";

        /// <summary>
        /// JABPP.
        /// </summary>
        public const string JABPP = "JABPP";

        /// <summary>
        /// JAFD01.
        /// </summary>
        public const string JAFD01 = "JAFD01";

        /// <summary>
        /// JAFD02.
        /// </summary>
        public const string JAFD02 = "JAFD02";

        /// <summary>
        /// JAFD03.
        /// </summary>
        public const string JAFD03 = "JAFD03";

        /// <summary>
        /// JAFD04.
        /// </summary>
        public const string JAFD04 = "JAFD04";

        /// <summary>
        /// JAFD05.
        /// </summary>
        public const string JAFD05 = "JAFD05";

        /// <summary>
        /// JATPP.
        /// </summary>
        public const string JATPP = "JATPP";
    }

    /// <inheritdoc />
    public override string TableName => "F4452";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAELEV", "JAELEV", JdeDataType.String, 6, true, true),
        new JdeField("JAPL", "JAPL", JdeDataType.String, 8, true, true),
        new JdeField("JADL01", "JADL01", JdeDataType.String, 60),
        new JdeField("JASQFT", "JASQFT", JdeDataType.Numeric),
        new JdeField("JASTRY", "JASTRY", JdeDataType.String, 8),
        new JdeField("JABEDR", "JABEDR", JdeDataType.String, 8),
        new JdeField("JABTH", "JABTH", JdeDataType.String, 8),
        new JdeField("JAAPLP", "JAAPLP", JdeDataType.String, 16),
        new JdeField("JAAYR", "JAAYR", JdeDataType.Numeric),
        new JdeField("JAMCUS", "JAMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JASPJ", "JASPJ", JdeDataType.Numeric),
        new JdeField("JABSP", "JABSP", JdeDataType.Numeric),
        new JdeField("JABPP", "JABPP", JdeDataType.Numeric),
        new JdeField("JAFD01", "JAFD01", JdeDataType.String, 6),
        new JdeField("JAFD02", "JAFD02", JdeDataType.String, 6),
        new JdeField("JAFD03", "JAFD03", JdeDataType.String, 6),
        new JdeField("JAFD04", "JAFD04", JdeDataType.String, 6),
        new JdeField("JAFD05", "JAFD05", JdeDataType.String, 6),
        new JdeField("JATPP", "JATPP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4452_0", "Primary Key on JAMCUS, JAPL, JAELEV", new[] { "JAMCUS", "JAPL", "JAELEV" }, isUnique: true, isPrimaryKey: true)
    };
}
