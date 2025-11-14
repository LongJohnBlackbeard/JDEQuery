using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H910 - .
/// </summary>
public class F74H910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VDKCO.
        /// </summary>
        public const string VDKCO = "VDKCO";

        /// <summary>
        /// VDDOC.
        /// </summary>
        public const string VDDOC = "VDDOC";

        /// <summary>
        /// VDDCT.
        /// </summary>
        public const string VDDCT = "VDDCT";

        /// <summary>
        /// VDEXR1.
        /// </summary>
        public const string VDEXR1 = "VDEXR1";

        /// <summary>
        /// VDTXA1.
        /// </summary>
        public const string VDTXA1 = "VDTXA1";

        /// <summary>
        /// VDVOD.
        /// </summary>
        public const string VDVOD = "VDVOD";

        /// <summary>
        /// VDCO.
        /// </summary>
        public const string VDCO = "VDCO";

        /// <summary>
        /// VDICU.
        /// </summary>
        public const string VDICU = "VDICU";

        /// <summary>
        /// VDICUT.
        /// </summary>
        public const string VDICUT = "VDICUT";

        /// <summary>
        /// VDH74JEDCT.
        /// </summary>
        public const string VDH74JEDCT = "VDH74JEDCT";

        /// <summary>
        /// VDH74JEDOC.
        /// </summary>
        public const string VDH74JEDOC = "VDH74JEDOC";

        /// <summary>
        /// VDH74JEKCO.
        /// </summary>
        public const string VDH74JEKCO = "VDH74JEKCO";

        /// <summary>
        /// VDH74JEDGJ.
        /// </summary>
        public const string VDH74JEDGJ = "VDH74JEDGJ";

        /// <summary>
        /// VDH74JELN.
        /// </summary>
        public const string VDH74JELN = "VDH74JELN";

        /// <summary>
        /// VDH74JELT.
        /// </summary>
        public const string VDH74JELT = "VDH74JELT";

        /// <summary>
        /// VDH74EXTL.
        /// </summary>
        public const string VDH74EXTL = "VDH74EXTL";

        /// <summary>
        /// VDH74VDIF.
        /// </summary>
        public const string VDH74VDIF = "VDH74VDIF";

        /// <summary>
        /// VDBCRC.
        /// </summary>
        public const string VDBCRC = "VDBCRC";

        /// <summary>
        /// VDUSER.
        /// </summary>
        public const string VDUSER = "VDUSER";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDUPMJ.
        /// </summary>
        public const string VDUPMJ = "VDUPMJ";

        /// <summary>
        /// VDUPMT.
        /// </summary>
        public const string VDUPMT = "VDUPMT";

        /// <summary>
        /// VDJOBN.
        /// </summary>
        public const string VDJOBN = "VDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74H910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VDKCO", "VDKCO", JdeDataType.String, 10, true, true),
        new JdeField("VDDOC", "VDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VDDCT", "VDDCT", JdeDataType.String, 4, true, true),
        new JdeField("VDEXR1", "VDEXR1", JdeDataType.String, 4, true, true),
        new JdeField("VDTXA1", "VDTXA1", JdeDataType.String, 20, true, true),
        new JdeField("VDVOD", "VDVOD", JdeDataType.String, 2, true, true),
        new JdeField("VDCO", "VDCO", JdeDataType.String, 10),
        new JdeField("VDICU", "VDICU", JdeDataType.Numeric),
        new JdeField("VDICUT", "VDICUT", JdeDataType.String, 4),
        new JdeField("VDH74JEDCT", "VDH74JEDCT", JdeDataType.String, 4),
        new JdeField("VDH74JEDOC", "VDH74JEDOC", JdeDataType.Numeric),
        new JdeField("VDH74JEKCO", "VDH74JEKCO", JdeDataType.String, 10),
        new JdeField("VDH74JEDGJ", "VDH74JEDGJ", JdeDataType.Numeric),
        new JdeField("VDH74JELN", "VDH74JELN", JdeDataType.Numeric),
        new JdeField("VDH74JELT", "VDH74JELT", JdeDataType.String, 4),
        new JdeField("VDH74EXTL", "VDH74EXTL", JdeDataType.String, 4),
        new JdeField("VDH74VDIF", "VDH74VDIF", JdeDataType.Numeric),
        new JdeField("VDBCRC", "VDBCRC", JdeDataType.String, 6),
        new JdeField("VDUSER", "VDUSER", JdeDataType.String, 20),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDUPMJ", "VDUPMJ", JdeDataType.Numeric),
        new JdeField("VDUPMT", "VDUPMT", JdeDataType.Numeric),
        new JdeField("VDJOBN", "VDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H910_0", "Primary Key on VDKCO, VDDOC, VDDCT, VDEXR1, VDTXA1, VDVOD", new[] { "VDKCO", "VDDOC", "VDDCT", "VDEXR1", "VDTXA1", "VDVOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74H910_2", "Index on VDH74JEDCT, VDH74JEDOC, VDH74JEKCO, SYS_NC00024$, VDH74JELN, VDH74JELT, VDH74EXTL", new[] { "VDH74JEDCT", "VDH74JEDOC", "VDH74JEKCO", "SYS_NC00024$", "VDH74JELN", "VDH74JELT", "VDH74EXTL" })
    };
}
