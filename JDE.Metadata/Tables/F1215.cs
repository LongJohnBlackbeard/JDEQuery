using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1215 - .
/// </summary>
public class F1215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GVEQCC.
        /// </summary>
        public const string GVEQCC = "GVEQCC";

        /// <summary>
        /// GVPGNM.
        /// </summary>
        public const string GVPGNM = "GVPGNM";

        /// <summary>
        /// GVLNGP.
        /// </summary>
        public const string GVLNGP = "GVLNGP";

        /// <summary>
        /// GVSPSQ.
        /// </summary>
        public const string GVSPSQ = "GVSPSQ";

        /// <summary>
        /// GVDESC.
        /// </summary>
        public const string GVDESC = "GVDESC";

        /// <summary>
        /// GVNUMF.
        /// </summary>
        public const string GVNUMF = "GVNUMF";

        /// <summary>
        /// GVFDTT.
        /// </summary>
        public const string GVFDTT = "GVFDTT";

        /// <summary>
        /// GVDTAS.
        /// </summary>
        public const string GVDTAS = "GVDTAS";

        /// <summary>
        /// GVCDEC.
        /// </summary>
        public const string GVCDEC = "GVCDEC";

        /// <summary>
        /// GVLRA.
        /// </summary>
        public const string GVLRA = "GVLRA";

        /// <summary>
        /// GVRT.
        /// </summary>
        public const string GVRT = "GVRT";

        /// <summary>
        /// GVSY.
        /// </summary>
        public const string GVSY = "GVSY";

        /// <summary>
        /// GVRQRD.
        /// </summary>
        public const string GVRQRD = "GVRQRD";

        /// <summary>
        /// GVFILE.
        /// </summary>
        public const string GVFILE = "GVFILE";

        /// <summary>
        /// GVUM.
        /// </summary>
        public const string GVUM = "GVUM";
    }

    /// <inheritdoc />
    public override string TableName => "F1215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GVEQCC", "GVEQCC", JdeDataType.String, 20, true, true),
        new JdeField("GVPGNM", "GVPGNM", JdeDataType.Numeric, null, true, true),
        new JdeField("GVLNGP", "GVLNGP", JdeDataType.String, 4, true, true),
        new JdeField("GVSPSQ", "GVSPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GVDESC", "GVDESC", JdeDataType.String, 60),
        new JdeField("GVNUMF", "GVNUMF", JdeDataType.Numeric),
        new JdeField("GVFDTT", "GVFDTT", JdeDataType.String, 2),
        new JdeField("GVDTAS", "GVDTAS", JdeDataType.Numeric),
        new JdeField("GVCDEC", "GVCDEC", JdeDataType.String, 2),
        new JdeField("GVLRA", "GVLRA", JdeDataType.String, 2),
        new JdeField("GVRT", "GVRT", JdeDataType.String, 4),
        new JdeField("GVSY", "GVSY", JdeDataType.String, 8),
        new JdeField("GVRQRD", "GVRQRD", JdeDataType.String, 2),
        new JdeField("GVFILE", "GVFILE", JdeDataType.String, 20),
        new JdeField("GVUM", "GVUM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1215_0", "Primary Key on GVEQCC, GVPGNM, GVLNGP, GVSPSQ", new[] { "GVEQCC", "GVPGNM", "GVLNGP", "GVSPSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
