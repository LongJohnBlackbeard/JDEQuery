using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101P - .
/// </summary>
public class F4101P : JdeTable
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
        /// IMUPCN.
        /// </summary>
        public const string IMUPCN = "IMUPCN";

        /// <summary>
        /// IMSCC0.
        /// </summary>
        public const string IMSCC0 = "IMSCC0";

        /// <summary>
        /// IMUMUP.
        /// </summary>
        public const string IMUMUP = "IMUMUP";

        /// <summary>
        /// IMUMDF.
        /// </summary>
        public const string IMUMDF = "IMUMDF";

        /// <summary>
        /// IMUMS0.
        /// </summary>
        public const string IMUMS0 = "IMUMS0";

        /// <summary>
        /// IMUMS1.
        /// </summary>
        public const string IMUMS1 = "IMUMS1";

        /// <summary>
        /// IMUMS2.
        /// </summary>
        public const string IMUMS2 = "IMUMS2";

        /// <summary>
        /// IMUMS3.
        /// </summary>
        public const string IMUMS3 = "IMUMS3";

        /// <summary>
        /// IMUMS4.
        /// </summary>
        public const string IMUMS4 = "IMUMS4";

        /// <summary>
        /// IMUMS5.
        /// </summary>
        public const string IMUMS5 = "IMUMS5";

        /// <summary>
        /// IMUMS6.
        /// </summary>
        public const string IMUMS6 = "IMUMS6";

        /// <summary>
        /// IMUMS7.
        /// </summary>
        public const string IMUMS7 = "IMUMS7";

        /// <summary>
        /// IMUMS8.
        /// </summary>
        public const string IMUMS8 = "IMUMS8";

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

        /// <summary>
        /// IMEQTY.
        /// </summary>
        public const string IMEQTY = "IMEQTY";

        /// <summary>
        /// IMWTRQ.
        /// </summary>
        public const string IMWTRQ = "IMWTRQ";
    }

    /// <inheritdoc />
    public override string TableName => "F4101P";

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
        new JdeField("IMUPCN", "IMUPCN", JdeDataType.String, 26),
        new JdeField("IMSCC0", "IMSCC0", JdeDataType.String, 28),
        new JdeField("IMUMUP", "IMUMUP", JdeDataType.String, 4),
        new JdeField("IMUMDF", "IMUMDF", JdeDataType.String, 4),
        new JdeField("IMUMS0", "IMUMS0", JdeDataType.String, 4),
        new JdeField("IMUMS1", "IMUMS1", JdeDataType.String, 4),
        new JdeField("IMUMS2", "IMUMS2", JdeDataType.String, 4),
        new JdeField("IMUMS3", "IMUMS3", JdeDataType.String, 4),
        new JdeField("IMUMS4", "IMUMS4", JdeDataType.String, 4),
        new JdeField("IMUMS5", "IMUMS5", JdeDataType.String, 4),
        new JdeField("IMUMS6", "IMUMS6", JdeDataType.String, 4),
        new JdeField("IMUMS7", "IMUMS7", JdeDataType.String, 4),
        new JdeField("IMUMS8", "IMUMS8", JdeDataType.String, 4),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric),
        new JdeField("IMEQTY", "IMEQTY", JdeDataType.String, 10),
        new JdeField("IMWTRQ", "IMWTRQ", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101P_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
