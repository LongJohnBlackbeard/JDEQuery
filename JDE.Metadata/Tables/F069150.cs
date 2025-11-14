using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069150 - .
/// </summary>
public class F069150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y1UN.
        /// </summary>
        public const string Y1UN = "Y1UN";

        /// <summary>
        /// Y1MCU.
        /// </summary>
        public const string Y1MCU = "Y1MCU";

        /// <summary>
        /// Y1JBCD.
        /// </summary>
        public const string Y1JBCD = "Y1JBCD";

        /// <summary>
        /// Y1JBST.
        /// </summary>
        public const string Y1JBST = "Y1JBST";

        /// <summary>
        /// Y1PSDT.
        /// </summary>
        public const string Y1PSDT = "Y1PSDT";

        /// <summary>
        /// Y1PDBA.
        /// </summary>
        public const string Y1PDBA = "Y1PDBA";

        /// <summary>
        /// Y1DISO.
        /// </summary>
        public const string Y1DISO = "Y1DISO";

        /// <summary>
        /// Y1GPPL.
        /// </summary>
        public const string Y1GPPL = "Y1GPPL";

        /// <summary>
        /// Y1GMDL.
        /// </summary>
        public const string Y1GMDL = "Y1GMDL";

        /// <summary>
        /// Y1GQDL.
        /// </summary>
        public const string Y1GQDL = "Y1GQDL";

        /// <summary>
        /// Y1GADL.
        /// </summary>
        public const string Y1GADL = "Y1GADL";

        /// <summary>
        /// Y1GSAL.
        /// </summary>
        public const string Y1GSAL = "Y1GSAL";

        /// <summary>
        /// Y1GPPX.
        /// </summary>
        public const string Y1GPPX = "Y1GPPX";

        /// <summary>
        /// Y1GHMN.
        /// </summary>
        public const string Y1GHMN = "Y1GHMN";

        /// <summary>
        /// Y1GHMX.
        /// </summary>
        public const string Y1GHMX = "Y1GHMX";

        /// <summary>
        /// Y1USER.
        /// </summary>
        public const string Y1USER = "Y1USER";

        /// <summary>
        /// Y1PID.
        /// </summary>
        public const string Y1PID = "Y1PID";

        /// <summary>
        /// Y1JOBN.
        /// </summary>
        public const string Y1JOBN = "Y1JOBN";

        /// <summary>
        /// Y1UPMJ.
        /// </summary>
        public const string Y1UPMJ = "Y1UPMJ";

        /// <summary>
        /// Y1UPMT.
        /// </summary>
        public const string Y1UPMT = "Y1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y1UN", "Y1UN", JdeDataType.String, 12, true, true),
        new JdeField("Y1MCU", "Y1MCU", JdeDataType.String, 24, true, true),
        new JdeField("Y1JBCD", "Y1JBCD", JdeDataType.String, 12, true, true),
        new JdeField("Y1JBST", "Y1JBST", JdeDataType.String, 8, true, true),
        new JdeField("Y1PSDT", "Y1PSDT", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1PDBA", "Y1PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1DISO", "Y1DISO", JdeDataType.String, 2, true, true),
        new JdeField("Y1GPPL", "Y1GPPL", JdeDataType.Numeric),
        new JdeField("Y1GMDL", "Y1GMDL", JdeDataType.Numeric),
        new JdeField("Y1GQDL", "Y1GQDL", JdeDataType.Numeric),
        new JdeField("Y1GADL", "Y1GADL", JdeDataType.Numeric),
        new JdeField("Y1GSAL", "Y1GSAL", JdeDataType.Numeric),
        new JdeField("Y1GPPX", "Y1GPPX", JdeDataType.Numeric),
        new JdeField("Y1GHMN", "Y1GHMN", JdeDataType.Numeric),
        new JdeField("Y1GHMX", "Y1GHMX", JdeDataType.Numeric),
        new JdeField("Y1USER", "Y1USER", JdeDataType.String, 20),
        new JdeField("Y1PID", "Y1PID", JdeDataType.String, 20),
        new JdeField("Y1JOBN", "Y1JOBN", JdeDataType.String, 20),
        new JdeField("Y1UPMJ", "Y1UPMJ", JdeDataType.Numeric),
        new JdeField("Y1UPMT", "Y1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069150_0", "Primary Key on Y1UN, Y1MCU, Y1JBCD, Y1JBST, Y1PSDT, Y1PDBA, Y1DISO", new[] { "Y1UN", "Y1MCU", "Y1JBCD", "Y1JBST", "Y1PSDT", "Y1PDBA", "Y1DISO" }, isUnique: true, isPrimaryKey: true)
    };
}
