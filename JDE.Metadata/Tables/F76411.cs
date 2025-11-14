using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76411 - .
/// </summary>
public class F76411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITITM.
        /// </summary>
        public const string ITITM = "ITITM";

        /// <summary>
        /// ITBCLF.
        /// </summary>
        public const string ITBCLF = "ITBCLF";

        /// <summary>
        /// ITBCTF.
        /// </summary>
        public const string ITBCTF = "ITBCTF";

        /// <summary>
        /// ITBICN.
        /// </summary>
        public const string ITBICN = "ITBICN";

        /// <summary>
        /// ITBIST.
        /// </summary>
        public const string ITBIST = "ITBIST";

        /// <summary>
        /// ITBORI.
        /// </summary>
        public const string ITBORI = "ITBORI";

        /// <summary>
        /// ITBCFC.
        /// </summary>
        public const string ITBCFC = "ITBCFC";

        /// <summary>
        /// ITBINM.
        /// </summary>
        public const string ITBINM = "ITBINM";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";

        /// <summary>
        /// ITUPMJ.
        /// </summary>
        public const string ITUPMJ = "ITUPMJ";

        /// <summary>
        /// ITTDAY.
        /// </summary>
        public const string ITTDAY = "ITTDAY";

        /// <summary>
        /// ITBRRTIR.
        /// </summary>
        public const string ITBRRTIR = "ITBRRTIR";

        /// <summary>
        /// ITBRRD.
        /// </summary>
        public const string ITBRRD = "ITBRRD";

        /// <summary>
        /// ITBRKINS.
        /// </summary>
        public const string ITBRKINS = "ITBRKINS";

        /// <summary>
        /// ITUTRIB.
        /// </summary>
        public const string ITUTRIB = "ITUTRIB";

        /// <summary>
        /// ITUCOM.
        /// </summary>
        public const string ITUCOM = "ITUCOM";

        /// <summary>
        /// ITITMTY.
        /// </summary>
        public const string ITITMTY = "ITITMTY";
    }

    /// <inheritdoc />
    public override string TableName => "F76411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITITM", "ITITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ITBCLF", "ITBCLF", JdeDataType.String, 20),
        new JdeField("ITBCTF", "ITBCTF", JdeDataType.String, 4),
        new JdeField("ITBICN", "ITBICN", JdeDataType.String, 2),
        new JdeField("ITBIST", "ITBIST", JdeDataType.String, 2),
        new JdeField("ITBORI", "ITBORI", JdeDataType.String, 2),
        new JdeField("ITBCFC", "ITBCFC", JdeDataType.String, 6),
        new JdeField("ITBINM", "ITBINM", JdeDataType.String, 20),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20),
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20),
        new JdeField("ITUPMJ", "ITUPMJ", JdeDataType.Numeric),
        new JdeField("ITTDAY", "ITTDAY", JdeDataType.Numeric),
        new JdeField("ITBRRTIR", "ITBRRTIR", JdeDataType.Numeric),
        new JdeField("ITBRRD", "ITBRRD", JdeDataType.Numeric),
        new JdeField("ITBRKINS", "ITBRKINS", JdeDataType.String, 2),
        new JdeField("ITUTRIB", "ITUTRIB", JdeDataType.String, 60),
        new JdeField("ITUCOM", "ITUCOM", JdeDataType.String, 60),
        new JdeField("ITITMTY", "ITITMTY", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76411_0", "Primary Key on ITITM", new[] { "ITITM" }, isUnique: true, isPrimaryKey: true)
    };
}
