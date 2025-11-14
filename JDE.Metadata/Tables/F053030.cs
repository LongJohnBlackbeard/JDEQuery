using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F053030 - .
/// </summary>
public class F053030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EWAN8.
        /// </summary>
        public const string EWAN8 = "EWAN8";

        /// <summary>
        /// EWDRQJ.
        /// </summary>
        public const string EWDRQJ = "EWDRQJ";

        /// <summary>
        /// EWRQTI.
        /// </summary>
        public const string EWRQTI = "EWRQTI";

        /// <summary>
        /// EWCALYEAR.
        /// </summary>
        public const string EWCALYEAR = "EWCALYEAR";

        /// <summary>
        /// EWW4MARST.
        /// </summary>
        public const string EWW4MARST = "EWW4MARST";

        /// <summary>
        /// EWW4NMCHFL.
        /// </summary>
        public const string EWW4NMCHFL = "EWW4NMCHFL";

        /// <summary>
        /// EWW4NOALL.
        /// </summary>
        public const string EWW4NOALL = "EWW4NOALL";

        /// <summary>
        /// EWW4AW.
        /// </summary>
        public const string EWW4AW = "EWW4AW";

        /// <summary>
        /// EWW4EXMFLG.
        /// </summary>
        public const string EWW4EXMFLG = "EWW4EXMFLG";

        /// <summary>
        /// EWCOMNT1.
        /// </summary>
        public const string EWCOMNT1 = "EWCOMNT1";

        /// <summary>
        /// EWCOMNT2.
        /// </summary>
        public const string EWCOMNT2 = "EWCOMNT2";

        /// <summary>
        /// EWFLGREV.
        /// </summary>
        public const string EWFLGREV = "EWFLGREV";

        /// <summary>
        /// EWJOBN.
        /// </summary>
        public const string EWJOBN = "EWJOBN";

        /// <summary>
        /// EWUSER.
        /// </summary>
        public const string EWUSER = "EWUSER";

        /// <summary>
        /// EWPID.
        /// </summary>
        public const string EWPID = "EWPID";

        /// <summary>
        /// EWUPMJ.
        /// </summary>
        public const string EWUPMJ = "EWUPMJ";

        /// <summary>
        /// EWW4MLJBFL.
        /// </summary>
        public const string EWW4MLJBFL = "EWW4MLJBFL";

        /// <summary>
        /// EWW4OTHINC.
        /// </summary>
        public const string EWW4OTHINC = "EWW4OTHINC";

        /// <summary>
        /// EWW4CLMDP1.
        /// </summary>
        public const string EWW4CLMDP1 = "EWW4CLMDP1";

        /// <summary>
        /// EWW4CLMDP2.
        /// </summary>
        public const string EWW4CLMDP2 = "EWW4CLMDP2";

        /// <summary>
        /// EWW4TLCLDP.
        /// </summary>
        public const string EWW4TLCLDP = "EWW4TLCLDP";

        /// <summary>
        /// EWW4DEDS.
        /// </summary>
        public const string EWW4DEDS = "EWW4DEDS";
    }

    /// <inheritdoc />
    public override string TableName => "F053030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EWAN8", "EWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EWDRQJ", "EWDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EWRQTI", "EWRQTI", JdeDataType.Numeric, null, true, true),
        new JdeField("EWCALYEAR", "EWCALYEAR", JdeDataType.Numeric),
        new JdeField("EWW4MARST", "EWW4MARST", JdeDataType.String, 2),
        new JdeField("EWW4NMCHFL", "EWW4NMCHFL", JdeDataType.String, 2),
        new JdeField("EWW4NOALL", "EWW4NOALL", JdeDataType.Numeric),
        new JdeField("EWW4AW", "EWW4AW", JdeDataType.Numeric),
        new JdeField("EWW4EXMFLG", "EWW4EXMFLG", JdeDataType.String, 2),
        new JdeField("EWCOMNT1", "EWCOMNT1", JdeDataType.String, 80),
        new JdeField("EWCOMNT2", "EWCOMNT2", JdeDataType.String, 80),
        new JdeField("EWFLGREV", "EWFLGREV", JdeDataType.String, 2),
        new JdeField("EWJOBN", "EWJOBN", JdeDataType.String, 20),
        new JdeField("EWUSER", "EWUSER", JdeDataType.String, 20),
        new JdeField("EWPID", "EWPID", JdeDataType.String, 20),
        new JdeField("EWUPMJ", "EWUPMJ", JdeDataType.Numeric),
        new JdeField("EWW4MLJBFL", "EWW4MLJBFL", JdeDataType.String, 2),
        new JdeField("EWW4OTHINC", "EWW4OTHINC", JdeDataType.Numeric),
        new JdeField("EWW4CLMDP1", "EWW4CLMDP1", JdeDataType.Numeric),
        new JdeField("EWW4CLMDP2", "EWW4CLMDP2", JdeDataType.Numeric),
        new JdeField("EWW4TLCLDP", "EWW4TLCLDP", JdeDataType.Numeric),
        new JdeField("EWW4DEDS", "EWW4DEDS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F053030_0", "Primary Key on EWAN8, EWDRQJ, EWRQTI", new[] { "EWAN8", "EWDRQJ", "EWRQTI" }, isUnique: true, isPrimaryKey: true)
    };
}
