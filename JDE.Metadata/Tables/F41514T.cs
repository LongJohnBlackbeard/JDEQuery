using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41514T - .
/// </summary>
public class F41514T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLMCU.
        /// </summary>
        public const string RLMCU = "RLMCU";

        /// <summary>
        /// RLITM.
        /// </summary>
        public const string RLITM = "RLITM";

        /// <summary>
        /// RLTKID.
        /// </summary>
        public const string RLTKID = "RLTKID";

        /// <summary>
        /// RLOPDT.
        /// </summary>
        public const string RLOPDT = "RLOPDT";

        /// <summary>
        /// RLRTTM.
        /// </summary>
        public const string RLRTTM = "RLRTTM";

        /// <summary>
        /// RLLOTN.
        /// </summary>
        public const string RLLOTN = "RLLOTN";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLTDAY.
        /// </summary>
        public const string RLTDAY = "RLTDAY";

        /// <summary>
        /// RLFUTCHAR1.
        /// </summary>
        public const string RLFUTCHAR1 = "RLFUTCHAR1";

        /// <summary>
        /// RLFUTCHAR2.
        /// </summary>
        public const string RLFUTCHAR2 = "RLFUTCHAR2";

        /// <summary>
        /// RLFUTCHAR3.
        /// </summary>
        public const string RLFUTCHAR3 = "RLFUTCHAR3";

        /// <summary>
        /// RLFUTSTR1.
        /// </summary>
        public const string RLFUTSTR1 = "RLFUTSTR1";

        /// <summary>
        /// RLFUTSTR2.
        /// </summary>
        public const string RLFUTSTR2 = "RLFUTSTR2";

        /// <summary>
        /// RLFUSTR3.
        /// </summary>
        public const string RLFUSTR3 = "RLFUSTR3";

        /// <summary>
        /// RLFUNUM1.
        /// </summary>
        public const string RLFUNUM1 = "RLFUNUM1";

        /// <summary>
        /// RLFUNUM2.
        /// </summary>
        public const string RLFUNUM2 = "RLFUNUM2";

        /// <summary>
        /// RLFUNUM3.
        /// </summary>
        public const string RLFUNUM3 = "RLFUNUM3";

        /// <summary>
        /// RLFUDT1.
        /// </summary>
        public const string RLFUDT1 = "RLFUDT1";
    }

    /// <inheritdoc />
    public override string TableName => "F41514T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLMCU", "RLMCU", JdeDataType.String, 24, true, true),
        new JdeField("RLITM", "RLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RLTKID", "RLTKID", JdeDataType.String, 16, true, true),
        new JdeField("RLOPDT", "RLOPDT", JdeDataType.Numeric, null, true, true),
        new JdeField("RLRTTM", "RLRTTM", JdeDataType.Numeric, null, true, true),
        new JdeField("RLLOTN", "RLLOTN", JdeDataType.String, 60),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLTDAY", "RLTDAY", JdeDataType.Numeric),
        new JdeField("RLFUTCHAR1", "RLFUTCHAR1", JdeDataType.String, 2),
        new JdeField("RLFUTCHAR2", "RLFUTCHAR2", JdeDataType.String, 2),
        new JdeField("RLFUTCHAR3", "RLFUTCHAR3", JdeDataType.String, 2),
        new JdeField("RLFUTSTR1", "RLFUTSTR1", JdeDataType.String, 100),
        new JdeField("RLFUTSTR2", "RLFUTSTR2", JdeDataType.String, 100),
        new JdeField("RLFUSTR3", "RLFUSTR3", JdeDataType.String, 100),
        new JdeField("RLFUNUM1", "RLFUNUM1", JdeDataType.Numeric),
        new JdeField("RLFUNUM2", "RLFUNUM2", JdeDataType.Numeric),
        new JdeField("RLFUNUM3", "RLFUNUM3", JdeDataType.Numeric),
        new JdeField("RLFUDT1", "RLFUDT1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41514T_0", "Primary Key on RLMCU, RLITM, RLTKID, RLOPDT, RLRTTM", new[] { "RLMCU", "RLITM", "RLTKID", "RLOPDT", "RLRTTM" }, isUnique: true, isPrimaryKey: true)
    };
}
