using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101S - .
/// </summary>
public class F4101S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMMCU.
        /// </summary>
        public const string IMMCU = "IMMCU";

        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMSTAW.
        /// </summary>
        public const string IMSTAW = "IMSTAW";

        /// <summary>
        /// IMEFFT.
        /// </summary>
        public const string IMEFFT = "IMEFFT";

        /// <summary>
        /// IMDOC.
        /// </summary>
        public const string IMDOC = "IMDOC";

        /// <summary>
        /// IMDCT.
        /// </summary>
        public const string IMDCT = "IMDCT";

        /// <summary>
        /// IMEFFF.
        /// </summary>
        public const string IMEFFF = "IMEFFF";

        /// <summary>
        /// IMSERK.
        /// </summary>
        public const string IMSERK = "IMSERK";

        /// <summary>
        /// IMNMFC.
        /// </summary>
        public const string IMNMFC = "IMNMFC";

        /// <summary>
        /// IMNMFI.
        /// </summary>
        public const string IMNMFI = "IMNMFI";

        /// <summary>
        /// IMSTCC.
        /// </summary>
        public const string IMSTCC = "IMSTCC";

        /// <summary>
        /// IMFRT1.
        /// </summary>
        public const string IMFRT1 = "IMFRT1";

        /// <summary>
        /// IMFRT2.
        /// </summary>
        public const string IMFRT2 = "IMFRT2";

        /// <summary>
        /// IMHSCD.
        /// </summary>
        public const string IMHSCD = "IMHSCD";

        /// <summary>
        /// IMPDCG.
        /// </summary>
        public const string IMPDCG = "IMPDCG";

        /// <summary>
        /// IMPFCT.
        /// </summary>
        public const string IMPFCT = "IMPFCT";

        /// <summary>
        /// IMECCN.
        /// </summary>
        public const string IMECCN = "IMECCN";

        /// <summary>
        /// IMDMFR.
        /// </summary>
        public const string IMDMFR = "IMDMFR";

        /// <summary>
        /// IMUNNA.
        /// </summary>
        public const string IMUNNA = "IMUNNA";

        /// <summary>
        /// IMHZDC.
        /// </summary>
        public const string IMHZDC = "IMHZDC";

        /// <summary>
        /// IMHZDL.
        /// </summary>
        public const string IMHZDL = "IMHZDL";

        /// <summary>
        /// IMFPNT.
        /// </summary>
        public const string IMFPNT = "IMFPNT";

        /// <summary>
        /// IMSTPU.
        /// </summary>
        public const string IMSTPU = "IMSTPU";

        /// <summary>
        /// IMPKGP.
        /// </summary>
        public const string IMPKGP = "IMPKGP";

        /// <summary>
        /// IMPKIN.
        /// </summary>
        public const string IMPKIN = "IMPKIN";

        /// <summary>
        /// IMSRSK.
        /// </summary>
        public const string IMSRSK = "IMSRSK";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMTDAY.
        /// </summary>
        public const string IMTDAY = "IMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4101S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMMCU", "IMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMSTAW", "IMSTAW", JdeDataType.String, 2, true, true),
        new JdeField("IMEFFT", "IMEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDOC", "IMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDCT", "IMDCT", JdeDataType.String, 4, true, true),
        new JdeField("IMEFFF", "IMEFFF", JdeDataType.Numeric),
        new JdeField("IMSERK", "IMSERK", JdeDataType.Numeric),
        new JdeField("IMNMFC", "IMNMFC", JdeDataType.String, 8),
        new JdeField("IMNMFI", "IMNMFI", JdeDataType.String, 12),
        new JdeField("IMSTCC", "IMSTCC", JdeDataType.String, 20),
        new JdeField("IMFRT1", "IMFRT1", JdeDataType.String, 12),
        new JdeField("IMFRT2", "IMFRT2", JdeDataType.String, 12),
        new JdeField("IMHSCD", "IMHSCD", JdeDataType.String, 24),
        new JdeField("IMPDCG", "IMPDCG", JdeDataType.String, 8),
        new JdeField("IMPFCT", "IMPFCT", JdeDataType.String, 2),
        new JdeField("IMECCN", "IMECCN", JdeDataType.String, 20),
        new JdeField("IMDMFR", "IMDMFR", JdeDataType.String, 2),
        new JdeField("IMUNNA", "IMUNNA", JdeDataType.String, 12),
        new JdeField("IMHZDC", "IMHZDC", JdeDataType.String, 6),
        new JdeField("IMHZDL", "IMHZDL", JdeDataType.String, 6),
        new JdeField("IMFPNT", "IMFPNT", JdeDataType.Numeric),
        new JdeField("IMSTPU", "IMSTPU", JdeDataType.String, 2),
        new JdeField("IMPKGP", "IMPKGP", JdeDataType.String, 6),
        new JdeField("IMPKIN", "IMPKIN", JdeDataType.String, 8),
        new JdeField("IMSRSK", "IMSRSK", JdeDataType.String, 6),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101S_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
