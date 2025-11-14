using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B50 - .
/// </summary>
public class F76B50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CECO.
        /// </summary>
        public const string CECO = "CECO";

        /// <summary>
        /// CESTRQ.
        /// </summary>
        public const string CESTRQ = "CESTRQ";

        /// <summary>
        /// CEBRDCTP.
        /// </summary>
        public const string CEBRDCTP = "CEBRDCTP";

        /// <summary>
        /// CEBRSSR.
        /// </summary>
        public const string CEBRSSR = "CEBRSSR";

        /// <summary>
        /// CEDOC.
        /// </summary>
        public const string CEDOC = "CEDOC";

        /// <summary>
        /// CEDGL.
        /// </summary>
        public const string CEDGL = "CEDGL";

        /// <summary>
        /// CEBRNCS.
        /// </summary>
        public const string CEBRNCS = "CEBRNCS";

        /// <summary>
        /// CELITM.
        /// </summary>
        public const string CELITM = "CELITM";

        /// <summary>
        /// CEBRNSE.
        /// </summary>
        public const string CEBRNSE = "CEBRNSE";

        /// <summary>
        /// CETRQT.
        /// </summary>
        public const string CETRQT = "CETRQT";

        /// <summary>
        /// CEUNCS.
        /// </summary>
        public const string CEUNCS = "CEUNCS";

        /// <summary>
        /// CEPAID.
        /// </summary>
        public const string CEPAID = "CEPAID";

        /// <summary>
        /// CECSTX.
        /// </summary>
        public const string CECSTX = "CECSTX";

        /// <summary>
        /// CEECST.
        /// </summary>
        public const string CEECST = "CEECST";

        /// <summary>
        /// CEMCU.
        /// </summary>
        public const string CEMCU = "CEMCU";

        /// <summary>
        /// CEOBJ.
        /// </summary>
        public const string CEOBJ = "CEOBJ";

        /// <summary>
        /// CESUB.
        /// </summary>
        public const string CESUB = "CESUB";

        /// <summary>
        /// CESBL.
        /// </summary>
        public const string CESBL = "CESBL";

        /// <summary>
        /// CEMCUS.
        /// </summary>
        public const string CEMCUS = "CEMCUS";

        /// <summary>
        /// CEOBJT.
        /// </summary>
        public const string CEOBJT = "CEOBJT";

        /// <summary>
        /// CESUBT.
        /// </summary>
        public const string CESUBT = "CESUBT";

        /// <summary>
        /// CESBLN.
        /// </summary>
        public const string CESBLN = "CESBLN";

        /// <summary>
        /// CEBRTPO.
        /// </summary>
        public const string CEBRTPO = "CEBRTPO";

        /// <summary>
        /// CELOC.
        /// </summary>
        public const string CELOC = "CELOC";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEEAP.
        /// </summary>
        public const string CEEAP = "CEEAP";

        /// <summary>
        /// CEJOBN.
        /// </summary>
        public const string CEJOBN = "CEJOBN";

        /// <summary>
        /// CEUPMJ.
        /// </summary>
        public const string CEUPMJ = "CEUPMJ";

        /// <summary>
        /// CEUPMT.
        /// </summary>
        public const string CEUPMT = "CEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CECO", "CECO", JdeDataType.String, 10, true, true),
        new JdeField("CESTRQ", "CESTRQ", JdeDataType.String, 6),
        new JdeField("CEBRDCTP", "CEBRDCTP", JdeDataType.String, 6),
        new JdeField("CEBRSSR", "CEBRSSR", JdeDataType.String, 10),
        new JdeField("CEDOC", "CEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CEDGL", "CEDGL", JdeDataType.Numeric),
        new JdeField("CEBRNCS", "CEBRNCS", JdeDataType.String, 28),
        new JdeField("CELITM", "CELITM", JdeDataType.String, 50, true, true),
        new JdeField("CEBRNSE", "CEBRNSE", JdeDataType.String, 30),
        new JdeField("CETRQT", "CETRQT", JdeDataType.Numeric),
        new JdeField("CEUNCS", "CEUNCS", JdeDataType.Numeric),
        new JdeField("CEPAID", "CEPAID", JdeDataType.Numeric),
        new JdeField("CECSTX", "CECSTX", JdeDataType.Numeric),
        new JdeField("CEECST", "CEECST", JdeDataType.Numeric),
        new JdeField("CEMCU", "CEMCU", JdeDataType.String, 24),
        new JdeField("CEOBJ", "CEOBJ", JdeDataType.String, 12),
        new JdeField("CESUB", "CESUB", JdeDataType.String, 16),
        new JdeField("CESBL", "CESBL", JdeDataType.String, 16),
        new JdeField("CEMCUS", "CEMCUS", JdeDataType.String, 24),
        new JdeField("CEOBJT", "CEOBJT", JdeDataType.String, 12),
        new JdeField("CESUBT", "CESUBT", JdeDataType.String, 16),
        new JdeField("CESBLN", "CESBLN", JdeDataType.String, 16),
        new JdeField("CEBRTPO", "CEBRTPO", JdeDataType.String, 6),
        new JdeField("CELOC", "CELOC", JdeDataType.String, 24),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEEAP", "CEEAP", JdeDataType.String, 20),
        new JdeField("CEJOBN", "CEJOBN", JdeDataType.String, 20),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B50_0", "Primary Key on CECO, CELITM, CEDOC", new[] { "CECO", "CELITM", "CEDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
