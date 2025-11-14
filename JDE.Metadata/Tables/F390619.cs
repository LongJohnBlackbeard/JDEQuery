using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F390619 - .
/// </summary>
public class F390619 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOCRCD.
        /// </summary>
        public const string SOCRCD = "SOCRCD";

        /// <summary>
        /// SOSVVM.
        /// </summary>
        public const string SOSVVM = "SOSVVM";

        /// <summary>
        /// SOSVYR.
        /// </summary>
        public const string SOSVYR = "SOSVYR";

        /// <summary>
        /// SOPNC.
        /// </summary>
        public const string SOPNC = "SOPNC";

        /// <summary>
        /// SOITPL.
        /// </summary>
        public const string SOITPL = "SOITPL";

        /// <summary>
        /// SOITM.
        /// </summary>
        public const string SOITM = "SOITM";

        /// <summary>
        /// SOCO.
        /// </summary>
        public const string SOCO = "SOCO";

        /// <summary>
        /// SOMCU.
        /// </summary>
        public const string SOMCU = "SOMCU";

        /// <summary>
        /// SOUOM.
        /// </summary>
        public const string SOUOM = "SOUOM";

        /// <summary>
        /// SOOPQT.
        /// </summary>
        public const string SOOPQT = "SOOPQT";

        /// <summary>
        /// SOOPAM.
        /// </summary>
        public const string SOOPAM = "SOOPAM";

        /// <summary>
        /// SOPEPQ.
        /// </summary>
        public const string SOPEPQ = "SOPEPQ";

        /// <summary>
        /// SOPEPA.
        /// </summary>
        public const string SOPEPA = "SOPEPA";

        /// <summary>
        /// SOPESL.
        /// </summary>
        public const string SOPESL = "SOPESL";

        /// <summary>
        /// SOPOAM.
        /// </summary>
        public const string SOPOAM = "SOPOAM";

        /// <summary>
        /// SOCLQT.
        /// </summary>
        public const string SOCLQT = "SOCLQT";

        /// <summary>
        /// SOCLAM.
        /// </summary>
        public const string SOCLAM = "SOCLAM";

        /// <summary>
        /// SOCGAM.
        /// </summary>
        public const string SOCGAM = "SOCGAM";

        /// <summary>
        /// SOCGAD.
        /// </summary>
        public const string SOCGAD = "SOCGAD";

        /// <summary>
        /// SOIVAD.
        /// </summary>
        public const string SOIVAD = "SOIVAD";

        /// <summary>
        /// SOLIAJ.
        /// </summary>
        public const string SOLIAJ = "SOLIAJ";

        /// <summary>
        /// SOLICS.
        /// </summary>
        public const string SOLICS = "SOLICS";

        /// <summary>
        /// SOGLPT.
        /// </summary>
        public const string SOGLPT = "SOGLPT";

        /// <summary>
        /// SOPSFL.
        /// </summary>
        public const string SOPSFL = "SOPSFL";

        /// <summary>
        /// SOSVQT.
        /// </summary>
        public const string SOSVQT = "SOSVQT";

        /// <summary>
        /// SOSVUM.
        /// </summary>
        public const string SOSVUM = "SOSVUM";

        /// <summary>
        /// SOSVDT.
        /// </summary>
        public const string SOSVDT = "SOSVDT";

        /// <summary>
        /// SOSVFU.
        /// </summary>
        public const string SOSVFU = "SOSVFU";

        /// <summary>
        /// SOSVF1.
        /// </summary>
        public const string SOSVF1 = "SOSVF1";

        /// <summary>
        /// SOSVF2.
        /// </summary>
        public const string SOSVF2 = "SOSVF2";

        /// <summary>
        /// SOSVF3.
        /// </summary>
        public const string SOSVF3 = "SOSVF3";

        /// <summary>
        /// SOSVF4.
        /// </summary>
        public const string SOSVF4 = "SOSVF4";

        /// <summary>
        /// SOSVF5.
        /// </summary>
        public const string SOSVF5 = "SOSVF5";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOPID.
        /// </summary>
        public const string SOPID = "SOPID";

        /// <summary>
        /// SOJOBN.
        /// </summary>
        public const string SOJOBN = "SOJOBN";

        /// <summary>
        /// SOUPMJ.
        /// </summary>
        public const string SOUPMJ = "SOUPMJ";

        /// <summary>
        /// SOTDAY.
        /// </summary>
        public const string SOTDAY = "SOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F390619";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOCRCD", "SOCRCD", JdeDataType.String, 6, true, true),
        new JdeField("SOSVVM", "SOSVVM", JdeDataType.String, 4, true, true),
        new JdeField("SOSVYR", "SOSVYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SOPNC", "SOPNC", JdeDataType.Numeric, null, true, true),
        new JdeField("SOITPL", "SOITPL", JdeDataType.String, 20, true, true),
        new JdeField("SOITM", "SOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SOCO", "SOCO", JdeDataType.String, 10, true, true),
        new JdeField("SOMCU", "SOMCU", JdeDataType.String, 24, true, true),
        new JdeField("SOUOM", "SOUOM", JdeDataType.String, 4),
        new JdeField("SOOPQT", "SOOPQT", JdeDataType.Numeric),
        new JdeField("SOOPAM", "SOOPAM", JdeDataType.Numeric),
        new JdeField("SOPEPQ", "SOPEPQ", JdeDataType.Numeric),
        new JdeField("SOPEPA", "SOPEPA", JdeDataType.Numeric),
        new JdeField("SOPESL", "SOPESL", JdeDataType.Numeric),
        new JdeField("SOPOAM", "SOPOAM", JdeDataType.Numeric),
        new JdeField("SOCLQT", "SOCLQT", JdeDataType.Numeric),
        new JdeField("SOCLAM", "SOCLAM", JdeDataType.Numeric),
        new JdeField("SOCGAM", "SOCGAM", JdeDataType.Numeric),
        new JdeField("SOCGAD", "SOCGAD", JdeDataType.Numeric),
        new JdeField("SOIVAD", "SOIVAD", JdeDataType.Numeric),
        new JdeField("SOLIAJ", "SOLIAJ", JdeDataType.Numeric),
        new JdeField("SOLICS", "SOLICS", JdeDataType.Numeric),
        new JdeField("SOGLPT", "SOGLPT", JdeDataType.String, 8),
        new JdeField("SOPSFL", "SOPSFL", JdeDataType.String, 2),
        new JdeField("SOSVQT", "SOSVQT", JdeDataType.Numeric),
        new JdeField("SOSVUM", "SOSVUM", JdeDataType.String, 4),
        new JdeField("SOSVDT", "SOSVDT", JdeDataType.Numeric),
        new JdeField("SOSVFU", "SOSVFU", JdeDataType.String, 4),
        new JdeField("SOSVF1", "SOSVF1", JdeDataType.String, 2),
        new JdeField("SOSVF2", "SOSVF2", JdeDataType.String, 2),
        new JdeField("SOSVF3", "SOSVF3", JdeDataType.String, 2),
        new JdeField("SOSVF4", "SOSVF4", JdeDataType.String, 2),
        new JdeField("SOSVF5", "SOSVF5", JdeDataType.String, 2),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20),
        new JdeField("SOPID", "SOPID", JdeDataType.String, 20),
        new JdeField("SOJOBN", "SOJOBN", JdeDataType.String, 20),
        new JdeField("SOUPMJ", "SOUPMJ", JdeDataType.Numeric),
        new JdeField("SOTDAY", "SOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F390619_0", "Primary Key on SOCRCD, SOSVVM, SOSVYR, SOPNC, SOITPL, SOITM, SOCO, SOMCU", new[] { "SOCRCD", "SOSVVM", "SOSVYR", "SOPNC", "SOITPL", "SOITM", "SOCO", "SOMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
