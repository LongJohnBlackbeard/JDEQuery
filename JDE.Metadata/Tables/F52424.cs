using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52424 - .
/// </summary>
public class F52424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKCO.
        /// </summary>
        public const string TKCO = "TKCO";

        /// <summary>
        /// TKCONNO.
        /// </summary>
        public const string TKCONNO = "TKCONNO";

        /// <summary>
        /// TKCONTYPE.
        /// </summary>
        public const string TKCONTYPE = "TKCONTYPE";

        /// <summary>
        /// TKJOBNO.
        /// </summary>
        public const string TKJOBNO = "TKJOBNO";

        /// <summary>
        /// TKPCONT.
        /// </summary>
        public const string TKPCONT = "TKPCONT";

        /// <summary>
        /// TKHOSTBU.
        /// </summary>
        public const string TKHOSTBU = "TKHOSTBU";

        /// <summary>
        /// TKCUSTNUM.
        /// </summary>
        public const string TKCUSTNUM = "TKCUSTNUM";

        /// <summary>
        /// TKCHONUM.
        /// </summary>
        public const string TKCHONUM = "TKCHONUM";

        /// <summary>
        /// TKBLNTYP.
        /// </summary>
        public const string TKBLNTYP = "TKBLNTYP";

        /// <summary>
        /// TKBLNNUM.
        /// </summary>
        public const string TKBLNNUM = "TKBLNNUM";

        /// <summary>
        /// TKCCCODE1.
        /// </summary>
        public const string TKCCCODE1 = "TKCCCODE1";

        /// <summary>
        /// TKCCCODE2.
        /// </summary>
        public const string TKCCCODE2 = "TKCCCODE2";

        /// <summary>
        /// TKCCCODE3.
        /// </summary>
        public const string TKCCCODE3 = "TKCCCODE3";

        /// <summary>
        /// TKCCCODE4.
        /// </summary>
        public const string TKCCCODE4 = "TKCCCODE4";

        /// <summary>
        /// TKCCCODE5.
        /// </summary>
        public const string TKCCCODE5 = "TKCCCODE5";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";
    }

    /// <inheritdoc />
    public override string TableName => "F52424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKCO", "TKCO", JdeDataType.String, 10, true, true),
        new JdeField("TKCONNO", "TKCONNO", JdeDataType.Numeric),
        new JdeField("TKCONTYPE", "TKCONTYPE", JdeDataType.Numeric),
        new JdeField("TKJOBNO", "TKJOBNO", JdeDataType.Numeric),
        new JdeField("TKPCONT", "TKPCONT", JdeDataType.Numeric),
        new JdeField("TKHOSTBU", "TKHOSTBU", JdeDataType.Numeric),
        new JdeField("TKCUSTNUM", "TKCUSTNUM", JdeDataType.Numeric),
        new JdeField("TKCHONUM", "TKCHONUM", JdeDataType.Numeric),
        new JdeField("TKBLNTYP", "TKBLNTYP", JdeDataType.Numeric),
        new JdeField("TKBLNNUM", "TKBLNNUM", JdeDataType.Numeric),
        new JdeField("TKCCCODE1", "TKCCCODE1", JdeDataType.Numeric),
        new JdeField("TKCCCODE2", "TKCCCODE2", JdeDataType.Numeric),
        new JdeField("TKCCCODE3", "TKCCCODE3", JdeDataType.Numeric),
        new JdeField("TKCCCODE4", "TKCCCODE4", JdeDataType.Numeric),
        new JdeField("TKCCCODE5", "TKCCCODE5", JdeDataType.Numeric),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52424_0", "Primary Key on TKCO", new[] { "TKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
