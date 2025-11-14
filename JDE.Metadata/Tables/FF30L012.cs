using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L012 - .
/// </summary>
public class FF30L012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KBFSCID.
        /// </summary>
        public const string KBFSCID = "KBFSCID";

        /// <summary>
        /// KBREPHRS.
        /// </summary>
        public const string KBREPHRS = "KBREPHRS";

        /// <summary>
        /// KBKANFAS.
        /// </summary>
        public const string KBKANFAS = "KBKANFAS";

        /// <summary>
        /// KBPKUOM.
        /// </summary>
        public const string KBPKUOM = "KBPKUOM";

        /// <summary>
        /// KBPKQTY.
        /// </summary>
        public const string KBPKQTY = "KBPKQTY";

        /// <summary>
        /// KBKANRSF.
        /// </summary>
        public const string KBKANRSF = "KBKANRSF";

        /// <summary>
        /// KBKAN1RSF.
        /// </summary>
        public const string KBKAN1RSF = "KBKAN1RSF";

        /// <summary>
        /// KBKAN2RSF.
        /// </summary>
        public const string KBKAN2RSF = "KBKAN2RSF";

        /// <summary>
        /// KBLBLKAN.
        /// </summary>
        public const string KBLBLKAN = "KBLBLKAN";

        /// <summary>
        /// KBLBLNRK.
        /// </summary>
        public const string KBLBLNRK = "KBLBLNRK";

        /// <summary>
        /// KBDCLBL.
        /// </summary>
        public const string KBDCLBL = "KBDCLBL";

        /// <summary>
        /// KBUDDEF.
        /// </summary>
        public const string KBUDDEF = "KBUDDEF";

        /// <summary>
        /// KBUDDEF2.
        /// </summary>
        public const string KBUDDEF2 = "KBUDDEF2";

        /// <summary>
        /// KBURCD.
        /// </summary>
        public const string KBURCD = "KBURCD";

        /// <summary>
        /// KBURDT.
        /// </summary>
        public const string KBURDT = "KBURDT";

        /// <summary>
        /// KBURAT.
        /// </summary>
        public const string KBURAT = "KBURAT";

        /// <summary>
        /// KBURAB.
        /// </summary>
        public const string KBURAB = "KBURAB";

        /// <summary>
        /// KBURRF.
        /// </summary>
        public const string KBURRF = "KBURRF";

        /// <summary>
        /// KBPID.
        /// </summary>
        public const string KBPID = "KBPID";

        /// <summary>
        /// KBUSER.
        /// </summary>
        public const string KBUSER = "KBUSER";

        /// <summary>
        /// KBMKEY.
        /// </summary>
        public const string KBMKEY = "KBMKEY";

        /// <summary>
        /// KBUUPMJ.
        /// </summary>
        public const string KBUUPMJ = "KBUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KBFSCID", "KBFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("KBREPHRS", "KBREPHRS", JdeDataType.Numeric),
        new JdeField("KBKANFAS", "KBKANFAS", JdeDataType.Numeric),
        new JdeField("KBPKUOM", "KBPKUOM", JdeDataType.String, 4),
        new JdeField("KBPKQTY", "KBPKQTY", JdeDataType.Numeric),
        new JdeField("KBKANRSF", "KBKANRSF", JdeDataType.Numeric),
        new JdeField("KBKAN1RSF", "KBKAN1RSF", JdeDataType.Numeric),
        new JdeField("KBKAN2RSF", "KBKAN2RSF", JdeDataType.Numeric),
        new JdeField("KBLBLKAN", "KBLBLKAN", JdeDataType.String, 6),
        new JdeField("KBLBLNRK", "KBLBLNRK", JdeDataType.String, 6),
        new JdeField("KBDCLBL", "KBDCLBL", JdeDataType.String, 6),
        new JdeField("KBUDDEF", "KBUDDEF", JdeDataType.String, 60),
        new JdeField("KBUDDEF2", "KBUDDEF2", JdeDataType.String, 60),
        new JdeField("KBURCD", "KBURCD", JdeDataType.String, 4),
        new JdeField("KBURDT", "KBURDT", JdeDataType.Numeric),
        new JdeField("KBURAT", "KBURAT", JdeDataType.Numeric),
        new JdeField("KBURAB", "KBURAB", JdeDataType.Numeric),
        new JdeField("KBURRF", "KBURRF", JdeDataType.String, 30),
        new JdeField("KBPID", "KBPID", JdeDataType.String, 20),
        new JdeField("KBUSER", "KBUSER", JdeDataType.String, 20),
        new JdeField("KBMKEY", "KBMKEY", JdeDataType.String, 30),
        new JdeField("KBUUPMJ", "KBUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L012_0", "Primary Key on KBFSCID", new[] { "KBFSCID" }, isUnique: true, isPrimaryKey: true)
    };
}
