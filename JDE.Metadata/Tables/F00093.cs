using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00093 - .
/// </summary>
public class F00093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FMFMDATA.
        /// </summary>
        public const string FMFMDATA = "FMFMDATA";

        /// <summary>
        /// FMFMTYP.
        /// </summary>
        public const string FMFMTYP = "FMFMTYP";

        /// <summary>
        /// FMFMTYPE.
        /// </summary>
        public const string FMFMTYPE = "FMFMTYPE";

        /// <summary>
        /// FMEFT.
        /// </summary>
        public const string FMEFT = "FMEFT";

        /// <summary>
        /// FMCEXP.
        /// </summary>
        public const string FMCEXP = "FMCEXP";

        /// <summary>
        /// FMFMCODE.
        /// </summary>
        public const string FMFMCODE = "FMFMCODE";

        /// <summary>
        /// FMFMPRI.
        /// </summary>
        public const string FMFMPRI = "FMFMPRI";

        /// <summary>
        /// FMUSER.
        /// </summary>
        public const string FMUSER = "FMUSER";

        /// <summary>
        /// FMUPMJ.
        /// </summary>
        public const string FMUPMJ = "FMUPMJ";

        /// <summary>
        /// FMUPMT.
        /// </summary>
        public const string FMUPMT = "FMUPMT";

        /// <summary>
        /// FMJOBN.
        /// </summary>
        public const string FMJOBN = "FMJOBN";

        /// <summary>
        /// FMPID.
        /// </summary>
        public const string FMPID = "FMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F00093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FMFMDATA", "FMFMDATA", JdeDataType.String, 60, true, true),
        new JdeField("FMFMTYP", "FMFMTYP", JdeDataType.String, 2, true, true),
        new JdeField("FMFMTYPE", "FMFMTYPE", JdeDataType.String, 4, true, true),
        new JdeField("FMEFT", "FMEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("FMCEXP", "FMCEXP", JdeDataType.Numeric, null, true, true),
        new JdeField("FMFMCODE", "FMFMCODE", JdeDataType.String, 4),
        new JdeField("FMFMPRI", "FMFMPRI", JdeDataType.String, 2),
        new JdeField("FMUSER", "FMUSER", JdeDataType.String, 20),
        new JdeField("FMUPMJ", "FMUPMJ", JdeDataType.Numeric),
        new JdeField("FMUPMT", "FMUPMT", JdeDataType.Numeric),
        new JdeField("FMJOBN", "FMJOBN", JdeDataType.String, 20),
        new JdeField("FMPID", "FMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00093_0", "Primary Key on FMFMDATA, FMFMTYP, FMFMTYPE, FMEFT, FMCEXP", new[] { "FMFMDATA", "FMFMTYP", "FMFMTYPE", "FMEFT", "FMCEXP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00093_4", "Index on FMFMTYP, FMFMDATA", new[] { "FMFMTYP", "FMFMDATA" })
    };
}
