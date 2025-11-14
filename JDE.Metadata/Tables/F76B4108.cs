using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4108 - .
/// </summary>
public class F76B4108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTITM.
        /// </summary>
        public const string LTITM = "LTITM";

        /// <summary>
        /// LTMCU.
        /// </summary>
        public const string LTMCU = "LTMCU";

        /// <summary>
        /// LTLOTN.
        /// </summary>
        public const string LTLOTN = "LTLOTN";

        /// <summary>
        /// LTLITM.
        /// </summary>
        public const string LTLITM = "LTLITM";

        /// <summary>
        /// LTAITM.
        /// </summary>
        public const string LTAITM = "LTAITM";

        /// <summary>
        /// LTMFGDT.
        /// </summary>
        public const string LTMFGDT = "LTMFGDT";

        /// <summary>
        /// LTMMEJ.
        /// </summary>
        public const string LTMMEJ = "LTMMEJ";

        /// <summary>
        /// LTPRDTR.
        /// </summary>
        public const string LTPRDTR = "LTPRDTR";

        /// <summary>
        /// LTFCHAR1.
        /// </summary>
        public const string LTFCHAR1 = "LTFCHAR1";

        /// <summary>
        /// LTFCHAR2.
        /// </summary>
        public const string LTFCHAR2 = "LTFCHAR2";

        /// <summary>
        /// LTFCHAR3.
        /// </summary>
        public const string LTFCHAR3 = "LTFCHAR3";

        /// <summary>
        /// LTFUDTE1.
        /// </summary>
        public const string LTFUDTE1 = "LTFUDTE1";

        /// <summary>
        /// LTFUDTE2.
        /// </summary>
        public const string LTFUDTE2 = "LTFUDTE2";

        /// <summary>
        /// LTFUDTE3.
        /// </summary>
        public const string LTFUDTE3 = "LTFUDTE3";

        /// <summary>
        /// LTFNUMB1.
        /// </summary>
        public const string LTFNUMB1 = "LTFNUMB1";

        /// <summary>
        /// LTFNUMB2.
        /// </summary>
        public const string LTFNUMB2 = "LTFNUMB2";

        /// <summary>
        /// LTFNUMB3.
        /// </summary>
        public const string LTFNUMB3 = "LTFNUMB3";

        /// <summary>
        /// LTFSTRN1.
        /// </summary>
        public const string LTFSTRN1 = "LTFSTRN1";

        /// <summary>
        /// LTFSTRN2.
        /// </summary>
        public const string LTFSTRN2 = "LTFSTRN2";

        /// <summary>
        /// LTFSTRN3.
        /// </summary>
        public const string LTFSTRN3 = "LTFSTRN3";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTTDAY.
        /// </summary>
        public const string LTTDAY = "LTTDAY";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTITM", "LTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LTMCU", "LTMCU", JdeDataType.String, 24, true, true),
        new JdeField("LTLOTN", "LTLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LTLITM", "LTLITM", JdeDataType.String, 50),
        new JdeField("LTAITM", "LTAITM", JdeDataType.String, 50),
        new JdeField("LTMFGDT", "LTMFGDT", JdeDataType.Numeric),
        new JdeField("LTMMEJ", "LTMMEJ", JdeDataType.Numeric),
        new JdeField("LTPRDTR", "LTPRDTR", JdeDataType.String, 2),
        new JdeField("LTFCHAR1", "LTFCHAR1", JdeDataType.String, 2),
        new JdeField("LTFCHAR2", "LTFCHAR2", JdeDataType.String, 2),
        new JdeField("LTFCHAR3", "LTFCHAR3", JdeDataType.String, 2),
        new JdeField("LTFUDTE1", "LTFUDTE1", JdeDataType.Numeric),
        new JdeField("LTFUDTE2", "LTFUDTE2", JdeDataType.Numeric),
        new JdeField("LTFUDTE3", "LTFUDTE3", JdeDataType.Numeric),
        new JdeField("LTFNUMB1", "LTFNUMB1", JdeDataType.Numeric),
        new JdeField("LTFNUMB2", "LTFNUMB2", JdeDataType.Numeric),
        new JdeField("LTFNUMB3", "LTFNUMB3", JdeDataType.Numeric),
        new JdeField("LTFSTRN1", "LTFSTRN1", JdeDataType.String, 100),
        new JdeField("LTFSTRN2", "LTFSTRN2", JdeDataType.String, 100),
        new JdeField("LTFSTRN3", "LTFSTRN3", JdeDataType.String, 100),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTTDAY", "LTTDAY", JdeDataType.Numeric),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4108_0", "Primary Key on LTITM, LTMCU, LTLOTN", new[] { "LTITM", "LTMCU", "LTLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
