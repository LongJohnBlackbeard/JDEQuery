using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1544 - .
/// </summary>
public class F1544 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBSASC.
        /// </summary>
        public const string OBSASC = "OBSASC";

        /// <summary>
        /// OBDL01.
        /// </summary>
        public const string OBDL01 = "OBDL01";

        /// <summary>
        /// OBDPTM.
        /// </summary>
        public const string OBDPTM = "OBDPTM";

        /// <summary>
        /// OBDPTY.
        /// </summary>
        public const string OBDPTY = "OBDPTY";

        /// <summary>
        /// OBCTMD.
        /// </summary>
        public const string OBCTMD = "OBCTMD";

        /// <summary>
        /// OBCTYD.
        /// </summary>
        public const string OBCTYD = "OBCTYD";

        /// <summary>
        /// OBMCFL.
        /// </summary>
        public const string OBMCFL = "OBMCFL";

        /// <summary>
        /// OBANFL.
        /// </summary>
        public const string OBANFL = "OBANFL";

        /// <summary>
        /// OBUNIF.
        /// </summary>
        public const string OBUNIF = "OBUNIF";

        /// <summary>
        /// OBDBAF.
        /// </summary>
        public const string OBDBAF = "OBDBAF";

        /// <summary>
        /// OBPRDF.
        /// </summary>
        public const string OBPRDF = "OBPRDF";

        /// <summary>
        /// OBCUSF.
        /// </summary>
        public const string OBCUSF = "OBCUSF";

        /// <summary>
        /// OBCOFL.
        /// </summary>
        public const string OBCOFL = "OBCOFL";

        /// <summary>
        /// OBDOFL.
        /// </summary>
        public const string OBDOFL = "OBDOFL";

        /// <summary>
        /// OBULIF.
        /// </summary>
        public const string OBULIF = "OBULIF";

        /// <summary>
        /// OBFLOF.
        /// </summary>
        public const string OBFLOF = "OBFLOF";

        /// <summary>
        /// OBM11F.
        /// </summary>
        public const string OBM11F = "OBM11F";

        /// <summary>
        /// OBM12F.
        /// </summary>
        public const string OBM12F = "OBM12F";

        /// <summary>
        /// OBM13F.
        /// </summary>
        public const string OBM13F = "OBM13F";

        /// <summary>
        /// OBM14F.
        /// </summary>
        public const string OBM14F = "OBM14F";

        /// <summary>
        /// OBM15F.
        /// </summary>
        public const string OBM15F = "OBM15F";

        /// <summary>
        /// OBANAF.
        /// </summary>
        public const string OBANAF = "OBANAF";

        /// <summary>
        /// OBSFCF.
        /// </summary>
        public const string OBSFCF = "OBSFCF";

        /// <summary>
        /// OBSFGF.
        /// </summary>
        public const string OBSFGF = "OBSFGF";

        /// <summary>
        /// OBSFBC.
        /// </summary>
        public const string OBSFBC = "OBSFBC";

        /// <summary>
        /// OBLGCL.
        /// </summary>
        public const string OBLGCL = "OBLGCL";

        /// <summary>
        /// OBAMID.
        /// </summary>
        public const string OBAMID = "OBAMID";

        /// <summary>
        /// OBCOL1.
        /// </summary>
        public const string OBCOL1 = "OBCOL1";

        /// <summary>
        /// OBCOL2.
        /// </summary>
        public const string OBCOL2 = "OBCOL2";

        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBPID.
        /// </summary>
        public const string OBPID = "OBPID";

        /// <summary>
        /// OBUPMJ.
        /// </summary>
        public const string OBUPMJ = "OBUPMJ";

        /// <summary>
        /// OBJOBN.
        /// </summary>
        public const string OBJOBN = "OBJOBN";

        /// <summary>
        /// OBEXCF.
        /// </summary>
        public const string OBEXCF = "OBEXCF";

        /// <summary>
        /// OBUPMT.
        /// </summary>
        public const string OBUPMT = "OBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1544";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBSASC", "OBSASC", JdeDataType.String, 4, true, true),
        new JdeField("OBDL01", "OBDL01", JdeDataType.String, 60),
        new JdeField("OBDPTM", "OBDPTM", JdeDataType.Numeric),
        new JdeField("OBDPTY", "OBDPTY", JdeDataType.Numeric),
        new JdeField("OBCTMD", "OBCTMD", JdeDataType.Numeric),
        new JdeField("OBCTYD", "OBCTYD", JdeDataType.Numeric),
        new JdeField("OBMCFL", "OBMCFL", JdeDataType.String, 2),
        new JdeField("OBANFL", "OBANFL", JdeDataType.String, 2),
        new JdeField("OBUNIF", "OBUNIF", JdeDataType.String, 2),
        new JdeField("OBDBAF", "OBDBAF", JdeDataType.String, 2),
        new JdeField("OBPRDF", "OBPRDF", JdeDataType.String, 2),
        new JdeField("OBCUSF", "OBCUSF", JdeDataType.String, 2),
        new JdeField("OBCOFL", "OBCOFL", JdeDataType.String, 2),
        new JdeField("OBDOFL", "OBDOFL", JdeDataType.String, 2),
        new JdeField("OBULIF", "OBULIF", JdeDataType.String, 2),
        new JdeField("OBFLOF", "OBFLOF", JdeDataType.String, 2),
        new JdeField("OBM11F", "OBM11F", JdeDataType.String, 2),
        new JdeField("OBM12F", "OBM12F", JdeDataType.String, 2),
        new JdeField("OBM13F", "OBM13F", JdeDataType.String, 2),
        new JdeField("OBM14F", "OBM14F", JdeDataType.String, 2),
        new JdeField("OBM15F", "OBM15F", JdeDataType.String, 2),
        new JdeField("OBANAF", "OBANAF", JdeDataType.String, 2),
        new JdeField("OBSFCF", "OBSFCF", JdeDataType.String, 2),
        new JdeField("OBSFGF", "OBSFGF", JdeDataType.String, 2),
        new JdeField("OBSFBC", "OBSFBC", JdeDataType.String, 2),
        new JdeField("OBLGCL", "OBLGCL", JdeDataType.String, 4),
        new JdeField("OBAMID", "OBAMID", JdeDataType.String, 8),
        new JdeField("OBCOL1", "OBCOL1", JdeDataType.String, 30),
        new JdeField("OBCOL2", "OBCOL2", JdeDataType.String, 30),
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20),
        new JdeField("OBPID", "OBPID", JdeDataType.String, 20),
        new JdeField("OBUPMJ", "OBUPMJ", JdeDataType.Numeric),
        new JdeField("OBJOBN", "OBJOBN", JdeDataType.String, 20),
        new JdeField("OBEXCF", "OBEXCF", JdeDataType.String, 2),
        new JdeField("OBUPMT", "OBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1544_0", "Primary Key on OBSASC", new[] { "OBSASC" }, isUnique: true, isPrimaryKey: true)
    };
}
