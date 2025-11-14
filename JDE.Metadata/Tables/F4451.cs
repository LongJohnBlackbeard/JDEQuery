using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4451 - .
/// </summary>
public class F4451 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JFMCUS.
        /// </summary>
        public const string JFMCUS = "JFMCUS";

        /// <summary>
        /// JFALOT.
        /// </summary>
        public const string JFALOT = "JFALOT";

        /// <summary>
        /// JFOPTN.
        /// </summary>
        public const string JFOPTN = "JFOPTN";

        /// <summary>
        /// JFSEQ2.
        /// </summary>
        public const string JFSEQ2 = "JFSEQ2";

        /// <summary>
        /// JFSKT.
        /// </summary>
        public const string JFSKT = "JFSKT";

        /// <summary>
        /// JFQT1.
        /// </summary>
        public const string JFQT1 = "JFQT1";

        /// <summary>
        /// JFSFXO.
        /// </summary>
        public const string JFSFXO = "JFSFXO";

        /// <summary>
        /// JFPCJ.
        /// </summary>
        public const string JFPCJ = "JFPCJ";

        /// <summary>
        /// JFJOBN.
        /// </summary>
        public const string JFJOBN = "JFJOBN";

        /// <summary>
        /// JFUSER.
        /// </summary>
        public const string JFUSER = "JFUSER";

        /// <summary>
        /// JFDL01.
        /// </summary>
        public const string JFDL01 = "JFDL01";

        /// <summary>
        /// JFSTCM.
        /// </summary>
        public const string JFSTCM = "JFSTCM";

        /// <summary>
        /// JFDL02.
        /// </summary>
        public const string JFDL02 = "JFDL02";

        /// <summary>
        /// JFPOST.
        /// </summary>
        public const string JFPOST = "JFPOST";

        /// <summary>
        /// JFSWG.
        /// </summary>
        public const string JFSWG = "JFSWG";

        /// <summary>
        /// JFSLPR.
        /// </summary>
        public const string JFSLPR = "JFSLPR";

        /// <summary>
        /// JFPSTD.
        /// </summary>
        public const string JFPSTD = "JFPSTD";

        /// <summary>
        /// JFUSRD.
        /// </summary>
        public const string JFUSRD = "JFUSRD";

        /// <summary>
        /// JFDG.
        /// </summary>
        public const string JFDG = "JFDG";

        /// <summary>
        /// JFTPQ.
        /// </summary>
        public const string JFTPQ = "JFTPQ";

        /// <summary>
        /// JFTYCG.
        /// </summary>
        public const string JFTYCG = "JFTYCG";

        /// <summary>
        /// JFPSG.
        /// </summary>
        public const string JFPSG = "JFPSG";

        /// <summary>
        /// JFQT2.
        /// </summary>
        public const string JFQT2 = "JFQT2";

        /// <summary>
        /// JFUSB1.
        /// </summary>
        public const string JFUSB1 = "JFUSB1";

        /// <summary>
        /// JFF1A.
        /// </summary>
        public const string JFF1A = "JFF1A";

        /// <summary>
        /// JFDTKN.
        /// </summary>
        public const string JFDTKN = "JFDTKN";

        /// <summary>
        /// JFOP01.
        /// </summary>
        public const string JFOP01 = "JFOP01";

        /// <summary>
        /// JFDP01.
        /// </summary>
        public const string JFDP01 = "JFDP01";

        /// <summary>
        /// JFDSC1.
        /// </summary>
        public const string JFDSC1 = "JFDSC1";

        /// <summary>
        /// JFDSC2.
        /// </summary>
        public const string JFDSC2 = "JFDSC2";

        /// <summary>
        /// JFVD1.
        /// </summary>
        public const string JFVD1 = "JFVD1";

        /// <summary>
        /// JFVD2.
        /// </summary>
        public const string JFVD2 = "JFVD2";
    }

    /// <inheritdoc />
    public override string TableName => "F4451";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JFMCUS", "JFMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JFALOT", "JFALOT", JdeDataType.String, 8, true, true),
        new JdeField("JFOPTN", "JFOPTN", JdeDataType.String, 16, true, true),
        new JdeField("JFSEQ2", "JFSEQ2", JdeDataType.Numeric),
        new JdeField("JFSKT", "JFSKT", JdeDataType.String, 16),
        new JdeField("JFQT1", "JFQT1", JdeDataType.Numeric),
        new JdeField("JFSFXO", "JFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("JFPCJ", "JFPCJ", JdeDataType.Numeric),
        new JdeField("JFJOBN", "JFJOBN", JdeDataType.String, 20),
        new JdeField("JFUSER", "JFUSER", JdeDataType.String, 20),
        new JdeField("JFDL01", "JFDL01", JdeDataType.String, 60),
        new JdeField("JFSTCM", "JFSTCM", JdeDataType.String, 60),
        new JdeField("JFDL02", "JFDL02", JdeDataType.String, 60),
        new JdeField("JFPOST", "JFPOST", JdeDataType.String, 2),
        new JdeField("JFSWG", "JFSWG", JdeDataType.String, 2),
        new JdeField("JFSLPR", "JFSLPR", JdeDataType.Numeric),
        new JdeField("JFPSTD", "JFPSTD", JdeDataType.Numeric),
        new JdeField("JFUSRD", "JFUSRD", JdeDataType.String, 20),
        new JdeField("JFDG", "JFDG", JdeDataType.Numeric),
        new JdeField("JFTPQ", "JFTPQ", JdeDataType.Numeric),
        new JdeField("JFTYCG", "JFTYCG", JdeDataType.String, 4),
        new JdeField("JFPSG", "JFPSG", JdeDataType.Numeric),
        new JdeField("JFQT2", "JFQT2", JdeDataType.Numeric),
        new JdeField("JFUSB1", "JFUSB1", JdeDataType.Numeric),
        new JdeField("JFF1A", "JFF1A", JdeDataType.Numeric),
        new JdeField("JFDTKN", "JFDTKN", JdeDataType.Numeric),
        new JdeField("JFOP01", "JFOP01", JdeDataType.String, 6),
        new JdeField("JFDP01", "JFDP01", JdeDataType.String, 6),
        new JdeField("JFDSC1", "JFDSC1", JdeDataType.String, 60),
        new JdeField("JFDSC2", "JFDSC2", JdeDataType.String, 60),
        new JdeField("JFVD1", "JFVD1", JdeDataType.String, 6),
        new JdeField("JFVD2", "JFVD2", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4451_0", "Primary Key on JFMCUS, JFALOT, JFOPTN, JFSFXO", new[] { "JFMCUS", "JFALOT", "JFOPTN", "JFSFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
