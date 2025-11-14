using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76412 - .
/// </summary>
public class F76412 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IJITM.
        /// </summary>
        public const string IJITM = "IJITM";

        /// <summary>
        /// IJMCU.
        /// </summary>
        public const string IJMCU = "IJMCU";

        /// <summary>
        /// IJLOCN.
        /// </summary>
        public const string IJLOCN = "IJLOCN";

        /// <summary>
        /// IJLOTN.
        /// </summary>
        public const string IJLOTN = "IJLOTN";

        /// <summary>
        /// IJBCLF.
        /// </summary>
        public const string IJBCLF = "IJBCLF";

        /// <summary>
        /// IJBCTF.
        /// </summary>
        public const string IJBCTF = "IJBCTF";

        /// <summary>
        /// IJBICN.
        /// </summary>
        public const string IJBICN = "IJBICN";

        /// <summary>
        /// IJBIST.
        /// </summary>
        public const string IJBIST = "IJBIST";

        /// <summary>
        /// IJBORI.
        /// </summary>
        public const string IJBORI = "IJBORI";

        /// <summary>
        /// IJBCFC.
        /// </summary>
        public const string IJBCFC = "IJBCFC";

        /// <summary>
        /// IJBINM.
        /// </summary>
        public const string IJBINM = "IJBINM";

        /// <summary>
        /// IJUSER.
        /// </summary>
        public const string IJUSER = "IJUSER";

        /// <summary>
        /// IJPID.
        /// </summary>
        public const string IJPID = "IJPID";

        /// <summary>
        /// IJJOBN.
        /// </summary>
        public const string IJJOBN = "IJJOBN";

        /// <summary>
        /// IJUPMJ.
        /// </summary>
        public const string IJUPMJ = "IJUPMJ";

        /// <summary>
        /// IJTDAY.
        /// </summary>
        public const string IJTDAY = "IJTDAY";

        /// <summary>
        /// IJBRRTIR.
        /// </summary>
        public const string IJBRRTIR = "IJBRRTIR";

        /// <summary>
        /// IJBRRD.
        /// </summary>
        public const string IJBRRD = "IJBRRD";

        /// <summary>
        /// IJBRKINS.
        /// </summary>
        public const string IJBRKINS = "IJBRKINS";

        /// <summary>
        /// IJITMTY.
        /// </summary>
        public const string IJITMTY = "IJITMTY";
    }

    /// <inheritdoc />
    public override string TableName => "F76412";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IJITM", "IJITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IJMCU", "IJMCU", JdeDataType.String, 24, true, true),
        new JdeField("IJLOCN", "IJLOCN", JdeDataType.String, 40, true, true),
        new JdeField("IJLOTN", "IJLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IJBCLF", "IJBCLF", JdeDataType.String, 20),
        new JdeField("IJBCTF", "IJBCTF", JdeDataType.String, 4),
        new JdeField("IJBICN", "IJBICN", JdeDataType.String, 2),
        new JdeField("IJBIST", "IJBIST", JdeDataType.String, 2),
        new JdeField("IJBORI", "IJBORI", JdeDataType.String, 2),
        new JdeField("IJBCFC", "IJBCFC", JdeDataType.String, 6),
        new JdeField("IJBINM", "IJBINM", JdeDataType.String, 20),
        new JdeField("IJUSER", "IJUSER", JdeDataType.String, 20),
        new JdeField("IJPID", "IJPID", JdeDataType.String, 20),
        new JdeField("IJJOBN", "IJJOBN", JdeDataType.String, 20),
        new JdeField("IJUPMJ", "IJUPMJ", JdeDataType.Numeric),
        new JdeField("IJTDAY", "IJTDAY", JdeDataType.Numeric),
        new JdeField("IJBRRTIR", "IJBRRTIR", JdeDataType.Numeric),
        new JdeField("IJBRRD", "IJBRRD", JdeDataType.Numeric),
        new JdeField("IJBRKINS", "IJBRKINS", JdeDataType.String, 2),
        new JdeField("IJITMTY", "IJITMTY", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76412_0", "Primary Key on IJITM, IJMCU, IJLOCN, IJLOTN", new[] { "IJITM", "IJMCU", "IJLOCN", "IJLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
