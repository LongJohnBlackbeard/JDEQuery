using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46R030 - .
/// </summary>
public class F46R030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESEPCHDR.
        /// </summary>
        public const string ESEPCHDR = "ESEPCHDR";

        /// <summary>
        /// ESEPCMGR.
        /// </summary>
        public const string ESEPCMGR = "ESEPCMGR";

        /// <summary>
        /// ESITM.
        /// </summary>
        public const string ESITM = "ESITM";

        /// <summary>
        /// ESEPCSRN.
        /// </summary>
        public const string ESEPCSRN = "ESEPCSRN";

        /// <summary>
        /// ESEPCINC.
        /// </summary>
        public const string ESEPCINC = "ESEPCINC";

        /// <summary>
        /// ESURCD.
        /// </summary>
        public const string ESURCD = "ESURCD";

        /// <summary>
        /// ESURDT.
        /// </summary>
        public const string ESURDT = "ESURDT";

        /// <summary>
        /// ESURRF.
        /// </summary>
        public const string ESURRF = "ESURRF";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESTDAY.
        /// </summary>
        public const string ESTDAY = "ESTDAY";

        /// <summary>
        /// ESMKEY.
        /// </summary>
        public const string ESMKEY = "ESMKEY";

        /// <summary>
        /// ESSVRNAME.
        /// </summary>
        public const string ESSVRNAME = "ESSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46R030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESEPCHDR", "ESEPCHDR", JdeDataType.String, 4, true, true),
        new JdeField("ESEPCMGR", "ESEPCMGR", JdeDataType.String, 40, true, true),
        new JdeField("ESITM", "ESITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ESEPCSRN", "ESEPCSRN", JdeDataType.String, 40),
        new JdeField("ESEPCINC", "ESEPCINC", JdeDataType.Numeric),
        new JdeField("ESURCD", "ESURCD", JdeDataType.String, 4),
        new JdeField("ESURDT", "ESURDT", JdeDataType.Numeric),
        new JdeField("ESURRF", "ESURRF", JdeDataType.String, 30),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESTDAY", "ESTDAY", JdeDataType.Numeric),
        new JdeField("ESMKEY", "ESMKEY", JdeDataType.String, 30),
        new JdeField("ESSVRNAME", "ESSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46R030_0", "Primary Key on ESEPCHDR, ESEPCMGR, ESITM", new[] { "ESEPCHDR", "ESEPCMGR", "ESITM" }, isUnique: true, isPrimaryKey: true)
    };
}
