using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05005 - .
/// </summary>
public class F05005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GFJOBS.
        /// </summary>
        public const string GFJOBS = "GFJOBS";

        /// <summary>
        /// GFSEQ.
        /// </summary>
        public const string GFSEQ = "GFSEQ";

        /// <summary>
        /// GFOBNM.
        /// </summary>
        public const string GFOBNM = "GFOBNM";

        /// <summary>
        /// GFDTAI.
        /// </summary>
        public const string GFDTAI = "GFDTAI";

        /// <summary>
        /// GFDL01.
        /// </summary>
        public const string GFDL01 = "GFDL01";

        /// <summary>
        /// GFDL02.
        /// </summary>
        public const string GFDL02 = "GFDL02";

        /// <summary>
        /// GFGS1A.
        /// </summary>
        public const string GFGS1A = "GFGS1A";

        /// <summary>
        /// GFGS1B.
        /// </summary>
        public const string GFGS1B = "GFGS1B";

        /// <summary>
        /// GFDS01.
        /// </summary>
        public const string GFDS01 = "GFDS01";

        /// <summary>
        /// GFDS02.
        /// </summary>
        public const string GFDS02 = "GFDS02";

        /// <summary>
        /// GFD200.
        /// </summary>
        public const string GFD200 = "GFD200";

        /// <summary>
        /// GFMATH01.
        /// </summary>
        public const string GFMATH01 = "GFMATH01";

        /// <summary>
        /// GFMATH02.
        /// </summary>
        public const string GFMATH02 = "GFMATH02";

        /// <summary>
        /// GFMATH03.
        /// </summary>
        public const string GFMATH03 = "GFMATH03";

        /// <summary>
        /// GFDATE01.
        /// </summary>
        public const string GFDATE01 = "GFDATE01";

        /// <summary>
        /// GFDATE02.
        /// </summary>
        public const string GFDATE02 = "GFDATE02";

        /// <summary>
        /// GFUSER.
        /// </summary>
        public const string GFUSER = "GFUSER";

        /// <summary>
        /// GFPID.
        /// </summary>
        public const string GFPID = "GFPID";

        /// <summary>
        /// GFUPMJ.
        /// </summary>
        public const string GFUPMJ = "GFUPMJ";

        /// <summary>
        /// GFUPMT.
        /// </summary>
        public const string GFUPMT = "GFUPMT";

        /// <summary>
        /// GFJOBN.
        /// </summary>
        public const string GFJOBN = "GFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F05005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GFJOBS", "GFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GFSEQ", "GFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GFOBNM", "GFOBNM", JdeDataType.String, 20, true, true),
        new JdeField("GFDTAI", "GFDTAI", JdeDataType.String, 20),
        new JdeField("GFDL01", "GFDL01", JdeDataType.String, 60),
        new JdeField("GFDL02", "GFDL02", JdeDataType.String, 60),
        new JdeField("GFGS1A", "GFGS1A", JdeDataType.String, 20),
        new JdeField("GFGS1B", "GFGS1B", JdeDataType.String, 20),
        new JdeField("GFDS01", "GFDS01", JdeDataType.String, 160),
        new JdeField("GFDS02", "GFDS02", JdeDataType.String, 160),
        new JdeField("GFD200", "GFD200", JdeDataType.String, 400),
        new JdeField("GFMATH01", "GFMATH01", JdeDataType.Numeric),
        new JdeField("GFMATH02", "GFMATH02", JdeDataType.Numeric),
        new JdeField("GFMATH03", "GFMATH03", JdeDataType.Numeric),
        new JdeField("GFDATE01", "GFDATE01", JdeDataType.Numeric),
        new JdeField("GFDATE02", "GFDATE02", JdeDataType.Numeric),
        new JdeField("GFUSER", "GFUSER", JdeDataType.String, 20),
        new JdeField("GFPID", "GFPID", JdeDataType.String, 20),
        new JdeField("GFUPMJ", "GFUPMJ", JdeDataType.Numeric),
        new JdeField("GFUPMT", "GFUPMT", JdeDataType.Numeric),
        new JdeField("GFJOBN", "GFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05005_0", "Primary Key on GFJOBS, GFSEQ, GFOBNM", new[] { "GFJOBS", "GFSEQ", "GFOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
