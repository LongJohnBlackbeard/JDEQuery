using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0721 - .
/// </summary>
public class F31B0721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPEURID.
        /// </summary>
        public const string EPEURID = "EPEURID";

        /// <summary>
        /// EPWISSC.
        /// </summary>
        public const string EPWISSC = "EPWISSC";

        /// <summary>
        /// EPMCU.
        /// </summary>
        public const string EPMCU = "EPMCU";

        /// <summary>
        /// EPPROTONO.
        /// </summary>
        public const string EPPROTONO = "EPPROTONO";

        /// <summary>
        /// EPPROTONM.
        /// </summary>
        public const string EPPROTONM = "EPPROTONM";

        /// <summary>
        /// EPPROTODS.
        /// </summary>
        public const string EPPROTODS = "EPPROTODS";

        /// <summary>
        /// EPPROTOC1.
        /// </summary>
        public const string EPPROTOC1 = "EPPROTOC1";

        /// <summary>
        /// EPPROTOC2.
        /// </summary>
        public const string EPPROTOC2 = "EPPROTOC2";

        /// <summary>
        /// EPPROTOC3.
        /// </summary>
        public const string EPPROTOC3 = "EPPROTOC3";

        /// <summary>
        /// EPPROTON1.
        /// </summary>
        public const string EPPROTON1 = "EPPROTON1";

        /// <summary>
        /// EPPROTON2.
        /// </summary>
        public const string EPPROTON2 = "EPPROTON2";

        /// <summary>
        /// EPPROTON3.
        /// </summary>
        public const string EPPROTON3 = "EPPROTON3";

        /// <summary>
        /// EPPROTOD1.
        /// </summary>
        public const string EPPROTOD1 = "EPPROTOD1";

        /// <summary>
        /// EPPROTOD2.
        /// </summary>
        public const string EPPROTOD2 = "EPPROTOD2";

        /// <summary>
        /// EPPROTOD3.
        /// </summary>
        public const string EPPROTOD3 = "EPPROTOD3";

        /// <summary>
        /// EPURAB.
        /// </summary>
        public const string EPURAB = "EPURAB";

        /// <summary>
        /// EPURAT.
        /// </summary>
        public const string EPURAT = "EPURAT";

        /// <summary>
        /// EPURCD.
        /// </summary>
        public const string EPURCD = "EPURCD";

        /// <summary>
        /// EPURDT.
        /// </summary>
        public const string EPURDT = "EPURDT";

        /// <summary>
        /// EPURRF.
        /// </summary>
        public const string EPURRF = "EPURRF";

        /// <summary>
        /// EPJOBN.
        /// </summary>
        public const string EPJOBN = "EPJOBN";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPTDAY.
        /// </summary>
        public const string EPTDAY = "EPTDAY";

        /// <summary>
        /// EPUPMJ.
        /// </summary>
        public const string EPUPMJ = "EPUPMJ";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPWAB.
        /// </summary>
        public const string EPWAB = "EPWAB";

        /// <summary>
        /// EPWCD.
        /// </summary>
        public const string EPWCD = "EPWCD";

        /// <summary>
        /// EPWMDT.
        /// </summary>
        public const string EPWMDT = "EPWMDT";

        /// <summary>
        /// EPWNUM.
        /// </summary>
        public const string EPWNUM = "EPWNUM";

        /// <summary>
        /// EPWRF.
        /// </summary>
        public const string EPWRF = "EPWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPEURID", "EPEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("EPWISSC", "EPWISSC", JdeDataType.String, 12, true, true),
        new JdeField("EPMCU", "EPMCU", JdeDataType.String, 24, true, true),
        new JdeField("EPPROTONO", "EPPROTONO", JdeDataType.Numeric, null, true, true),
        new JdeField("EPPROTONM", "EPPROTONM", JdeDataType.String, 24),
        new JdeField("EPPROTODS", "EPPROTODS", JdeDataType.String, 60),
        new JdeField("EPPROTOC1", "EPPROTOC1", JdeDataType.String, 20),
        new JdeField("EPPROTOC2", "EPPROTOC2", JdeDataType.String, 20),
        new JdeField("EPPROTOC3", "EPPROTOC3", JdeDataType.String, 20),
        new JdeField("EPPROTON1", "EPPROTON1", JdeDataType.Numeric),
        new JdeField("EPPROTON2", "EPPROTON2", JdeDataType.Numeric),
        new JdeField("EPPROTON3", "EPPROTON3", JdeDataType.Numeric),
        new JdeField("EPPROTOD1", "EPPROTOD1", JdeDataType.Numeric),
        new JdeField("EPPROTOD2", "EPPROTOD2", JdeDataType.Numeric),
        new JdeField("EPPROTOD3", "EPPROTOD3", JdeDataType.Numeric),
        new JdeField("EPURAB", "EPURAB", JdeDataType.Numeric),
        new JdeField("EPURAT", "EPURAT", JdeDataType.Numeric),
        new JdeField("EPURCD", "EPURCD", JdeDataType.String, 4),
        new JdeField("EPURDT", "EPURDT", JdeDataType.Numeric),
        new JdeField("EPURRF", "EPURRF", JdeDataType.String, 30),
        new JdeField("EPJOBN", "EPJOBN", JdeDataType.String, 20),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPTDAY", "EPTDAY", JdeDataType.Numeric),
        new JdeField("EPUPMJ", "EPUPMJ", JdeDataType.Numeric),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPWAB", "EPWAB", JdeDataType.Numeric),
        new JdeField("EPWCD", "EPWCD", JdeDataType.String, 6),
        new JdeField("EPWMDT", "EPWMDT", JdeDataType.Numeric),
        new JdeField("EPWNUM", "EPWNUM", JdeDataType.Numeric),
        new JdeField("EPWRF", "EPWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0721_0", "Primary Key on EPEURID, EPWISSC, EPMCU, EPPROTONO", new[] { "EPEURID", "EPWISSC", "EPMCU", "EPPROTONO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0721_2", "Index on EPEURID, EPWISSC, EPMCU, SYS_NC00031$", new[] { "EPEURID", "EPWISSC", "EPMCU", "SYS_NC00031$" }),
        new JdeIndex("F31B0721_3", "Index on EPPROTONM, EPEURID, EPWISSC, EPMCU, EPPROTONO", new[] { "EPPROTONM", "EPEURID", "EPWISSC", "EPMCU", "EPPROTONO" })
    };
}
