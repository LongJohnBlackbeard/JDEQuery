using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41500T - .
/// </summary>
public class F41500T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLTKID.
        /// </summary>
        public const string PLTKID = "PLTKID";

        /// <summary>
        /// PLLOTNC.
        /// </summary>
        public const string PLLOTNC = "PLLOTNC";

        /// <summary>
        /// PLLOTNP.
        /// </summary>
        public const string PLLOTNP = "PLLOTNP";

        /// <summary>
        /// PLLOTNRC.
        /// </summary>
        public const string PLLOTNRC = "PLLOTNRC";

        /// <summary>
        /// PLLOTNRP.
        /// </summary>
        public const string PLLOTNRP = "PLLOTNRP";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLTDAY.
        /// </summary>
        public const string PLTDAY = "PLTDAY";

        /// <summary>
        /// PLFUTCHAR1.
        /// </summary>
        public const string PLFUTCHAR1 = "PLFUTCHAR1";

        /// <summary>
        /// PLFUTCHAR2.
        /// </summary>
        public const string PLFUTCHAR2 = "PLFUTCHAR2";

        /// <summary>
        /// PLFUTCHAR3.
        /// </summary>
        public const string PLFUTCHAR3 = "PLFUTCHAR3";

        /// <summary>
        /// PLFUTSTR1.
        /// </summary>
        public const string PLFUTSTR1 = "PLFUTSTR1";

        /// <summary>
        /// PLFUTSTR2.
        /// </summary>
        public const string PLFUTSTR2 = "PLFUTSTR2";

        /// <summary>
        /// PLFUSTR3.
        /// </summary>
        public const string PLFUSTR3 = "PLFUSTR3";

        /// <summary>
        /// PLFUNUM1.
        /// </summary>
        public const string PLFUNUM1 = "PLFUNUM1";

        /// <summary>
        /// PLFUNUM2.
        /// </summary>
        public const string PLFUNUM2 = "PLFUNUM2";

        /// <summary>
        /// PLFUNUM3.
        /// </summary>
        public const string PLFUNUM3 = "PLFUNUM3";

        /// <summary>
        /// PLFUDT1.
        /// </summary>
        public const string PLFUDT1 = "PLFUDT1";
    }

    /// <inheritdoc />
    public override string TableName => "F41500T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24, true, true),
        new JdeField("PLTKID", "PLTKID", JdeDataType.String, 16, true, true),
        new JdeField("PLLOTNC", "PLLOTNC", JdeDataType.String, 60),
        new JdeField("PLLOTNP", "PLLOTNP", JdeDataType.String, 60),
        new JdeField("PLLOTNRC", "PLLOTNRC", JdeDataType.String, 60),
        new JdeField("PLLOTNRP", "PLLOTNRP", JdeDataType.String, 60),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLTDAY", "PLTDAY", JdeDataType.Numeric),
        new JdeField("PLFUTCHAR1", "PLFUTCHAR1", JdeDataType.String, 2),
        new JdeField("PLFUTCHAR2", "PLFUTCHAR2", JdeDataType.String, 2),
        new JdeField("PLFUTCHAR3", "PLFUTCHAR3", JdeDataType.String, 2),
        new JdeField("PLFUTSTR1", "PLFUTSTR1", JdeDataType.String, 100),
        new JdeField("PLFUTSTR2", "PLFUTSTR2", JdeDataType.String, 100),
        new JdeField("PLFUSTR3", "PLFUSTR3", JdeDataType.String, 100),
        new JdeField("PLFUNUM1", "PLFUNUM1", JdeDataType.Numeric),
        new JdeField("PLFUNUM2", "PLFUNUM2", JdeDataType.Numeric),
        new JdeField("PLFUNUM3", "PLFUNUM3", JdeDataType.Numeric),
        new JdeField("PLFUDT1", "PLFUDT1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41500T_0", "Primary Key on PLMCU, PLTKID", new[] { "PLMCU", "PLTKID" }, isUnique: true, isPrimaryKey: true)
    };
}
