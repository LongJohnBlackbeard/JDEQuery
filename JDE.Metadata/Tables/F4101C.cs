using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101C - .
/// </summary>
public class F4101C : JdeTable
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
        /// IMITBR.
        /// </summary>
        public const string IMITBR = "IMITBR";

        /// <summary>
        /// IMSRP1.
        /// </summary>
        public const string IMSRP1 = "IMSRP1";

        /// <summary>
        /// IMSRP2.
        /// </summary>
        public const string IMSRP2 = "IMSRP2";

        /// <summary>
        /// IMSRP3.
        /// </summary>
        public const string IMSRP3 = "IMSRP3";

        /// <summary>
        /// IMSRP4.
        /// </summary>
        public const string IMSRP4 = "IMSRP4";

        /// <summary>
        /// IMSRP5.
        /// </summary>
        public const string IMSRP5 = "IMSRP5";

        /// <summary>
        /// IMSRP6.
        /// </summary>
        public const string IMSRP6 = "IMSRP6";

        /// <summary>
        /// IMSRP7.
        /// </summary>
        public const string IMSRP7 = "IMSRP7";

        /// <summary>
        /// IMSRP8.
        /// </summary>
        public const string IMSRP8 = "IMSRP8";

        /// <summary>
        /// IMSRP9.
        /// </summary>
        public const string IMSRP9 = "IMSRP9";

        /// <summary>
        /// IMSRP0.
        /// </summary>
        public const string IMSRP0 = "IMSRP0";

        /// <summary>
        /// IMPRP1.
        /// </summary>
        public const string IMPRP1 = "IMPRP1";

        /// <summary>
        /// IMPRP2.
        /// </summary>
        public const string IMPRP2 = "IMPRP2";

        /// <summary>
        /// IMPRP3.
        /// </summary>
        public const string IMPRP3 = "IMPRP3";

        /// <summary>
        /// IMPRP4.
        /// </summary>
        public const string IMPRP4 = "IMPRP4";

        /// <summary>
        /// IMPRP5.
        /// </summary>
        public const string IMPRP5 = "IMPRP5";

        /// <summary>
        /// IMPRP6.
        /// </summary>
        public const string IMPRP6 = "IMPRP6";

        /// <summary>
        /// IMPRP7.
        /// </summary>
        public const string IMPRP7 = "IMPRP7";

        /// <summary>
        /// IMPRP8.
        /// </summary>
        public const string IMPRP8 = "IMPRP8";

        /// <summary>
        /// IMPRP9.
        /// </summary>
        public const string IMPRP9 = "IMPRP9";

        /// <summary>
        /// IMPRP0.
        /// </summary>
        public const string IMPRP0 = "IMPRP0";

        /// <summary>
        /// IMCARS.
        /// </summary>
        public const string IMCARS = "IMCARS";

        /// <summary>
        /// IMCARP.
        /// </summary>
        public const string IMCARP = "IMCARP";

        /// <summary>
        /// IMSHCN.
        /// </summary>
        public const string IMSHCN = "IMSHCN";

        /// <summary>
        /// IMSHCM.
        /// </summary>
        public const string IMSHCM = "IMSHCM";

        /// <summary>
        /// IMCYCL.
        /// </summary>
        public const string IMCYCL = "IMCYCL";

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
    public override string TableName => "F4101C";

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
        new JdeField("IMITBR", "IMITBR", JdeDataType.String, 2),
        new JdeField("IMSRP1", "IMSRP1", JdeDataType.String, 6),
        new JdeField("IMSRP2", "IMSRP2", JdeDataType.String, 6),
        new JdeField("IMSRP3", "IMSRP3", JdeDataType.String, 6),
        new JdeField("IMSRP4", "IMSRP4", JdeDataType.String, 6),
        new JdeField("IMSRP5", "IMSRP5", JdeDataType.String, 6),
        new JdeField("IMSRP6", "IMSRP6", JdeDataType.String, 12),
        new JdeField("IMSRP7", "IMSRP7", JdeDataType.String, 12),
        new JdeField("IMSRP8", "IMSRP8", JdeDataType.String, 12),
        new JdeField("IMSRP9", "IMSRP9", JdeDataType.String, 12),
        new JdeField("IMSRP0", "IMSRP0", JdeDataType.String, 12),
        new JdeField("IMPRP1", "IMPRP1", JdeDataType.String, 6),
        new JdeField("IMPRP2", "IMPRP2", JdeDataType.String, 6),
        new JdeField("IMPRP3", "IMPRP3", JdeDataType.String, 6),
        new JdeField("IMPRP4", "IMPRP4", JdeDataType.String, 6),
        new JdeField("IMPRP5", "IMPRP5", JdeDataType.String, 6),
        new JdeField("IMPRP6", "IMPRP6", JdeDataType.String, 12),
        new JdeField("IMPRP7", "IMPRP7", JdeDataType.String, 12),
        new JdeField("IMPRP8", "IMPRP8", JdeDataType.String, 12),
        new JdeField("IMPRP9", "IMPRP9", JdeDataType.String, 12),
        new JdeField("IMPRP0", "IMPRP0", JdeDataType.String, 12),
        new JdeField("IMCARS", "IMCARS", JdeDataType.Numeric),
        new JdeField("IMCARP", "IMCARP", JdeDataType.Numeric),
        new JdeField("IMSHCN", "IMSHCN", JdeDataType.String, 6),
        new JdeField("IMSHCM", "IMSHCM", JdeDataType.String, 6),
        new JdeField("IMCYCL", "IMCYCL", JdeDataType.String, 6),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101C_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
